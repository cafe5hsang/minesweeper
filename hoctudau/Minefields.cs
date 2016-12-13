using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_DataStructAndAlgorithms
{

    public partial class Minefields : UserControl
    {
        #region Playing event
        public event EventHandler CellClick;
        public event EventHandler firebombEvent;

        private void OnCellClick()
        {
            if (CellClick != null)
                CellClick(this, null);
        }
        protected void firebombNotify()
        {
            if (firebombEvent != null)
                firebombEvent(this, null);
        }

        #endregion

        #region Properties

        const int CELL_SIZE = 25;
        Color[] color_picker = {
        Color.Blue,Color.Green,Color.Red,Color.Purple,Color.Peru,
        Color.PaleGreen,Color.Orchid,Color.Olive};

        Image IMG_GRASS;
        Image IMG_BOMB;
        Image IMG_FLAG;
        //Image _imgExplode;

        Mines _mines;

        public bool IsLost 
        { 
            get { return _mines._is_lost; } 
        }

        public int Rows
        {
            get { return _mines._rows; }
        }
        public int Cols
        {
            get { return _mines._cols; }
        }
        public int MinesCount
        {
            get { return _mines._mines_count; }
        }
        
        public int FlagsCount 
        { 
            get { return _mines._flags_count; } 
        }

        public int RemainCellsCount 
        { 
            get { return Rows * Cols - _mines._cell_open; } 
        }

        #endregion

        public Minefields()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            IMG_BOMB = new Bitmap(Properties.Resources.bomb, CELL_SIZE, CELL_SIZE);
            IMG_FLAG = new Bitmap(Properties.Resources.flag, CELL_SIZE, CELL_SIZE);
            IMG_GRASS = new Bitmap(Properties.Resources.grass, CELL_SIZE, CELL_SIZE);
            //_imgExplode = Properties.Resources.explode;

            _mines = new Mines();
        }

        public void NewGame()
        {
            _mines.New();

            this.Width = CELL_SIZE * _mines._cols + 3;
            this.Height = CELL_SIZE * _mines._rows + 3;
            Invalidate();
        }

        public void NewGame(int rows, int cols, int mines)
        {
            _mines.New(rows, cols, mines);

            this.Width = CELL_SIZE * _mines._cols;
            this.Height = CELL_SIZE * _mines._rows;
            Invalidate();
        }


        void firebomb(int left, int top)
        {
            _mines._is_lost = true;
            firebombNotify();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int y = e.X / CELL_SIZE;
            int x = e.Y / CELL_SIZE;
            if (_mines[x, y]._is_open)
                return;

            if (!_mines._is_first)
            {                
                _mines._is_first = true;
                _mines[x, y]._is_first_click = true;
                _mines.Init();
            }
            if (!_mines._is_lost && !_mines._is_win && _mines._is_first)
            {
                if (!_mines[x, y]._is_flag && e.Button == MouseButtons.Left)
                {
                    if (_mines.OpenCell(x, y))                                            
                        firebomb(e.X,e.Y);
                    else
                    {
                        // win
                        if (RemainCellsCount == MinesCount)
                        {
                            _mines._is_win = true;

                            // flag
                            for (int i = 0; i < Rows; i++)
                            {
                                for (int j = 0; j < Cols; j++)
                                {
                                    if (!_mines[i, j]._is_open)
                                        _mines[i, j]._is_flag = true;
                                }
                            }
                        }
                    }

                    Invalidate();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (_mines[x, y]._is_mark)
                    {
                        _mines[x, y]._is_mark = false;
                    }
                    else
                    {
                        _mines[x, y]._is_flag = !_mines[x, y]._is_flag;
                        _mines[x, y]._is_mark = !_mines[x, y]._is_flag;

                        if (_mines[x, y]._is_flag)
                            _mines._flags_count++;
                        else
                            _mines._flags_count--;
                    }
                    Invalidate();

                }
                // event click
                OnCellClick();
            }
            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.LightGray, 0, 0, this.Width, this.Height);

            for (int i = 0; i < _mines._rows; i++)
            {
                int y = CELL_SIZE * i;

                for (int j = 0; j < _mines._cols; j++)
                {
                    int x = CELL_SIZE * j;

                    if (_mines[i, j]._is_open)
                    {
                        if (_mines[i, j]._is_mine)
                        {
                            // where die?
                            e.Graphics.FillRectangle(Brushes.Red, x, y, CELL_SIZE, CELL_SIZE);
                        }
                        else if (_mines[i, j]._mines_around > 0)
                        {
                            string str_mines_around = _mines[i, j]._mines_around.ToString();
                            SizeF size = e.Graphics.MeasureString(str_mines_around, this.Font);

                            e.Graphics.DrawString(str_mines_around,
                                this.Font, new SolidBrush(color_picker[_mines[i, j]._mines_around - 1]),
                                    x + (CELL_SIZE - size.Width) / 2, y + (CELL_SIZE - size.Height) / 2);
                        }
                    }
                    else
                    {
                        e.Graphics.DrawImage(IMG_GRASS, x, y);
                    }

                    // if lost
                    if (_mines._is_lost)
                    {
                        if (_mines[i, j]._is_mine)
                        {
                            e.Graphics.DrawImage(IMG_BOMB, x, y);
                        }
                    }

                    if (_mines[i, j]._is_flag)
                    {
                        e.Graphics.DrawImage(IMG_FLAG, x, y);
                    }
                    else if (_mines[i, j]._is_mark)
                    {
                        string str_question = "?";
                        SizeF size = e.Graphics.MeasureString(str_question, this.Font);

                        e.Graphics.DrawString(str_question,
                            this.Font, Brushes.Black,
                                x + (CELL_SIZE - size.Width) / 2, y + (CELL_SIZE - size.Height) / 2);

                    }
                    // vertical
                    e.Graphics.DrawLine(Pens.Gray, x, 0, x, this.Height);
                }

                // hoz
                e.Graphics.DrawLine(Pens.Gray, 0, y, this.Width, y);
            }
        }

        private void minefields_Load(object sender, EventArgs e)
        {

        }
    }
}
