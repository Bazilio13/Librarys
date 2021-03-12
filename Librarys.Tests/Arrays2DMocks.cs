using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys.Tests
{
    public class Arrays2DMocks
    {
        public static int[,] GetMock(int MockNumber)
        {
            int[,] mock;

            switch (MockNumber)
            {
                default:
                    mock = new int[,] { };
                    break;
                case 1:
                    mock = new int[,]
                    {
                        {1, 6, -5, 0 },
                        {-2, 7, 3, 10 },
                        {4, -4, 12, 9 },
                        {3, 0, -11, 6 }
                    };
                    break;
                case 2:
                    mock = new int[,]
                    {
                        {-5, -4, -2, 0 },
                        {10, -8, 8, -13 }
                    };
                    break;
                case 3:
                    mock = new int[,]
                    {
                        {0, 3 },
                        {6, 4 },
                        {-5, -4 },
                        {10, -8 }
                    };
                    break;
                case 4:
                    mock = new int[,]
                    {
                        {1, -2, 4, 3 },
                        {6, 7, -4, 0 },
                        {-5, 3, 12, -11 },
                        {0, 10, 9, 6 }
                    };
                    break;
                case 5:
                    mock = new int[,]
                    {
                        {-5, 10 },
                        {-4, -8 },
                        {-2, 8 },
                        {0, -13 }
                    };
                    break;
                case 6:
                    mock = new int[,]
                    {
                        {0, 6, -5, 10 },
                        {3, 4, -4, -8 }
                    };
                    break;
            }
            return mock;
        }
    }
}
