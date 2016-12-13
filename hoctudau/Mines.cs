using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_DataStructAndAlgorithms
{
    public class Cell
    {
        public bool _is_open = false;
        public bool _is_mark = false;
        public bool _is_flag = false;
        public bool _is_mine = false;
        public bool _is_first_click = false;
        public int _mines_around = 0;
    }

    public class Mines
    {
        Cell[,] _cells;
        public Cell this[int row, int col]
        {
            get 
            { 
                return _cells[row, col]; 
            }
        }

        public int _cells_count;
        public int _rows;
        public int _cols;
        public int _mines_count;
        public int _flags_count;
        public int _cell_open;

        public bool _is_win;
        public bool _is_lost;

        // first load
        public bool _is_first;

        public Mines()
            : this(8, 8, 10)
        {

        }
        public Mines(int rows, int cols, int minesCount)
        {
            New(rows, cols, minesCount);
        }
        public void New()
        {
            New(_rows, _cols, _mines_count);
        }
        public void New(int rows, int cols, int minesCount)
        {
            this._rows = rows;
            this._cols = cols;
            this._mines_count = minesCount;
            this._cells_count = _rows * _cols;

            _cell_open = 0;
            _is_win = false;
            _is_lost = false;
            _flags_count = 0;

            // first click
            _is_first = false;

            InitStart();
        }

        public void InitStart()
        {
            // declare cell
            _cells = new Cell[_rows, _cols];
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                    _cells[i, j] = new Cell();
        }
        //private
        public void Init()
        {
            /*
            // declare cell
            _cells = new Cell[_rows, _cols];
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                    _cells[i, j] = new Cell();
            */
            // put bomb
            Random random = new Random();
            int num_bomb_puted = 0;
            while (num_bomb_puted < _mines_count)
            {
                int number_random = random.Next(_cells_count);
                int x = number_random / _cols;
                int y = number_random % _cols;

                // put bomb
                if (!_cells[x, y]._is_mine && !_cells[x,y]._is_first_click)
                {
                    _cells[x, y]._is_mine = true;
                    num_bomb_puted++;
                }
            }

        }

        /**
         * Open cell
         * 
         */
        public bool OpenCell(int row, int col)
        {
            if (_cells[row, col]._is_open || _cells[row, col]._is_flag)
                return false;
            
            // Open cell & delete mark
            _cells[row, col]._is_open = true;
            _cells[row, col]._is_mark = false;
            _cell_open++;

            // fire bum bum
            if (_cells[row, col]._is_mine)
                return true;

            // Count bomb around 
            int count_bomb_around = countMinesAround(row, col);

            if (count_bomb_around > 0)
            {
                _cells[row, col]._mines_around = count_bomb_around;
            }
            else
            {
                int row_buf = row == 0 ? 0 : -1;
                int col_buf = col == 0 ? 0 : -1;
                int row_lim = row == _rows - 1 ? 1 : 2;
                int col_lim = col == _cols - 1 ? 1 : 2;

                for (; row_buf < row_lim; row_buf++)
                    for (int j = col_buf; j < col_lim; j++)
                    {
                        OpenCell(row + row_buf, col + j);
                    }
            }
            return false;
        }
        /**
         * mines around cell
         * 
         */
        private int countMinesAround(int row, int col)
        {
            int num_bom_around = 0;
            
            int row_buf  = row == 0 ? 0 : -1;
            int row_lim  = row == _rows - 1 ? 1 : 2;
            
            int col_buf  = col == 0 ? 0 : -1;
            int col_lim  = col == _cols - 1 ? 1 : 2;

            for (; row_buf < row_lim; row_buf++)
                for (int j = col_buf; j < col_lim; j++)
                {
                    if (_cells[row + row_buf, col + j]._is_mine)
                        num_bom_around++;
                }
            return num_bom_around;
        }

    }
}
