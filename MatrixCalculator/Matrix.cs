using System;

namespace MatrixCalculator
{
    public class Matrix
    {
        public static void YazdirHata(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\a\n{0}\n\a", mesaj);
            Console.ResetColor();
        }

        /// <summary>
        /// Matrix creator
        /// </summary>
        /// <param name="line"> Line Number</param>
        /// <param name="column"> Column Number</param>
        /// <param name="Max">Max value </param>
        /// <param name="Mini">Mini value</param>
        /// <returns></returns>
        public static int[,] CreatMatrix(int line, int column
            , int Mini, int Max)
        {
            var rand = new Random();
            int[,] X = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    X[i, j] = rand.Next(Mini, Max);
                }

            }

            return X;
        }
        /// <summary>
        /// Parametre olarak aldiği iki boyutlu matrisi ekrana yazar.
        /// Writes the two-dimensional matrix it takes as a parameter on the screen.
        /// </summary>
        /// <param name="X"></param>
        public static void PrintMatrix(int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write("{0,4}", X[i, j]);
                }
                Console.WriteLine("  ");
            }
        }
        public static void PrintMatrix(double[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write("{0,4}", X[i, j]);
                }
                Console.WriteLine("  ");
            }
        }
        /// <summary>
        /// Parametre olarak aldiği tek boyutlu matrisi ekrana yazar.
        /// Writes the one-dimensional matrix it takes as a parameter on the screen.
        /// </summary>
        /// <param name="X"></param>
        public static void PrintMatrix2(int[] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                Console.Write("{0,5}", X[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Zeroo Matrix creator .
        /// </summary>
        /// <param name="Line">Number of Line</param>
        /// <param name="column">Number of column</param>
        /// <returns>Zeroo Matrix</returns>
        public static int[,] ZerooMatrix(int Line, int column)
        {
            int[,] X = CreatMatrix(Line, column, 0, 0);
            return X;
        }
        /// <summary>
        /// One Matrix creator .
        /// </summary>
        /// <param name="Line">Number of Line</param>
        /// <param name="column">Number of column</param>
        /// <returns>One Matrix</returns>
        public static int[,] OneMatrix(int Line, int column)
        {
            int[,] X = CreatMatrix(Line, column, 1, 1);
            return X;
        }
        /// <summary>
        /// Diagonal Matrix Creator.
        /// </summary>
        /// <param name="line"> Line Number</param>
        /// <param name="column"> Column Number</param>
        /// <param name="Max">Max value </param>
        /// <param name="Mini">Mini value</param>
        /// <returns>Diagonal Matrix</returns>
        public static int[,] DiagonalMatrix(int line, int column
            , int Mini, int Max)
        {
            int[,] X = ZerooMatrix(line, column);

            for (int i = 0; i < line; i++)
            {

                X[i, i] = new Random().Next(Mini, Max);
            }
            return X;
        }
        /// <summary>
        /// Scalar matrix creator.
        /// </summary>
        /// <param name="line">Number of line</param>
        /// <param name="column">Number of column</param>
        /// <param name="Mini">Mini value</param>
        /// <param name="Max">Max value</param>
        /// <returns>Scalar matrix</returns>
        public static int[,] ScalarMatrix(int line, int column
            , int Mini, int Max)
        {
            int[,] X = DiagonalMatrix(line, column, Mini, Max);
            return X;
        }
        /// <summary>
        /// Square matrix ?
        /// Kare matrisi kontrolü yapar.
        /// </summary>
        /// <param name="Y">Matrix</param>
        /// <returns>Result </returns>
        public static bool SquareMatrixControl(int[,] Y)
        {
            return (Y.GetLength(0) == Y.GetLength(1)) ?
                true : false;

        }
        /// <summary>
        /// One matrix ?
        /// Birim matrisi kontrolü yapar.
        /// </summary>
        /// <param name="Y">Matrix</param>
        /// <returns>Result </returns>
        public static bool OneMatrixControl(int[,] Y)
        {
            bool control = true;
            for (int i = 0; (i < Y.GetLength(0) && control == true); i++)
            {
                for (int j = 0; j < Y.GetLength(1); j++)
                {
                    if (Y[i, j] != 0 && i != j)
                    {
                        control = false;
                        break;
                    }
                    else
                    {
                        if (Y[i, j] != 1 && i == j)
                        {
                            control = false;
                            break;
                        }
                    }
                }
            }
            return control;
        }
        /// <summary>
        /// Returns diagonel elements as an new array.
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Diagonal Numbers List</returns>
        public static int[] DiagonalNumList(int[,] X)
        {

            if (SquareMatrixControl(X))
            {
                int[] D = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    D[i] = X[i, i];

                }
                return D;
            }
            else
            {
                Console.WriteLine("Please enter a square matrix");
                return new int[1];
            }

        }
        /// <summary>
        /// Bir matrisin izini hesaplar
        /// Calculates the trace of a matrix.
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Result</returns>
        public static int MatrixTraceCalculator(int[,] X)
        {
            int t = 0;

            if (SquareMatrixControl(X))
            {
                int[] D = DiagonalNumList(X);
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    t += X[i, i];
                }
                return t;
            }
            else
            {
                Console.WriteLine("Please enter a square matrix");
                return t;
            }

        }
        /// <summary>
        /// Matrisin transpozu alır.
        /// Transposition of the matrix.
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Transposition</returns>
        public static int[,] TranspositionOfTheMatrix(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = X[j, i];
                }

            }
            return T;
        }
        /// <summary>
        /// Reshape the matrix
        /// Matrisi yeniden şekilendir
        /// </summary>
        /// <param name="X">MatrixNumber of lines</param>
        /// <param name="NewLine">Number of column</param>
        /// <param name="NewColumn"></param>
        /// <returns>Result Reshape Matrix</returns>
        public static int[,] ReshapeMatrix(int[,] X, int NewLine, int NewColumn)
        {
            if (X.Length == NewLine * NewColumn)
            {
                int[] D = new int[X.Length];
                int[,] Y = new int[NewLine, NewColumn];
                int num = 0;
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        D[num] = X[i, j];
                        num++;
                    }
                }
                Console.WriteLine();
                PrintMatrix2(D);
                Console.WriteLine();
                num = 0;
                for (int i = 0; i < Y.GetLength(0); i++)
                {
                    for (int j = 0; j < NewColumn; j++)
                    {
                        Y[i, j] = D[num];
                        num++;
                    }
                }
                return Y;
            }
            else
            {
                YazdirHata("Something went wrong");
                return new int[1, 1];
            }
        }
        /// <summary>
        /// İki matris karşilaştiran algoritma (Elmanları farklı mı ? boyutları aynı mı? ) .
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool MatrixComparison(int[,] x, int[,] y)
        {
            bool s = true;
            // boyut kontrolu
            if (x.GetLength(0) == y.GetLength(0)
                && x.GetLength(1) == y.GetLength(1))
            {
                // Eleman kontrolu
                for (int i = 0; i < x.GetLength(1); i++)
                {
                    for (int j = 0; j < x.GetLength(1); j++)
                    {
                        if (x[i, j] != y[i, j])
                        {
                            s = false;
                            break;
                        }

                    }
                }
            }
            else
            {
                s = false;
            }
            return s;
        }
        /// <summary>
        /// Calculates the determinant of the matrix Not just (2x2) and (3x3) .
        /// Matrisin determinamtı hesaplar sadece (2x2) ve (3x3) matrisler için .
        /// </summary>
        /// <param name="x">Matrix</param>
        /// <returns>Determinant</returns>
        public static int MatrixDeterminant2(int[,] x)
        {
            int d = -1;
            if (SquareMatrixControl(x))
            {
                if (x.Length == 4)
                {
                    d = x[0, 0] * x[1, 1] - x[0, 1] * x[1, 0];
                    return d;
                }
                else if (x.Length == 9)
                {
                    d = x[0, 0] * (x[1, 1] * x[2, 2] - x[1, 2] * x[2, 1]) -
                        x[0, 1] * (x[1, 0] * x[2, 2] - x[2, 0] * x[1, 2]) +
                        x[0, 2] * (x[1, 0] * x[2, 1] - x[1, 1] * x[2, 0]);
                    return d;
                }
                else
                {
                    YazdirHata("Tanımlı bir boyut yok!.");
                    return d;
                }

            }
            else
            {
                YazdirHata("Parametre kare matris olmalı. ");
                return d;
            }
        }
        /// <summary>
        /// Skaler bir deger ile matris carpar .
        /// Multiplies the matrix by a scalar value.
        /// </summary>
        /// <param name="c">Skaler deger</param>
        /// <param name="X">Matrix</param>
        /// <returns>Carpım sonucu</returns>
        public static int[,] ScalerMulti(int c, int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    X[i, j] = c * X[i, j];
                }
            }
            return X;
        }
        /// <summary>
        /// Summing the elements of the matrix.
        /// Matrisin elemanları toplayan algoritma.
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Elements sum</returns>
        public static int MatrixElementSum(int[,] X)
        {
            int t = 0;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    t += X[i, j];
                }
            }
            return t;
        }
        /// <summary>
        /// Create a symmetric matrix
        /// Simetrik matrisi olusturur .
        /// </summary>
        /// <param name="line">Line number</param>
        /// <param name="column">column number</param>
        /// <param name="Mini">Minimum value</param>
        /// <param name="Max">Max value</param>
        /// <returns>Symetric Matrix</returns>
        public static int[,] CreateSymmetricMatrix(int line, int column, int Mini, int Max)
        {
            int[,] X = DiagonalMatrix(line, column, Mini, Max);
            var rand = new Random();

            for (int i = 1; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    X[i, j] = rand.Next(Mini, Max);
                    X[j, i] = X[i, j];

                }
            }
            return X;


        }
        /// <summary>
        /// Symmetric Control
        /// Parametre olarak girilen matris simetrik mi ? belirlenen algoritma
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Symmetric Control true or false</returns>
        public static bool SymmetricControl(int[,] X)
        {
            int[,] Y = Matrix.TranspositionOfTheMatrix(X);
            return MatrixComparison(X, Y);
        }
        /// <summary>
        /// Diagonal Matrix controlor.
        /// Matrislerin diagonal olup olmadigini kontrol eder .
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>Diagonal Matrix (yes) or (not)</returns>
        public static bool DiagonalMatrixControl(int[,] X)
        {
            bool s = true;
            if (SquareMatrixControl(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (!(X[i, j] == 0))
                            if (i != j)
                            {
                                s = false;
                                break;
                            }
                    }
                }

            }
            else
            {
                YazdirHata("Kare matris degildir");
                s = false;
            }
            return s;
        }
        /// <summary>
        /// Bir üst üçgen matris oluşturmak.
        /// Create an upper triangular matrix.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="column"></param>
        /// <param name="Mini"></param>
        /// <param name="Max"></param>
        /// <returns></returns>
        public static int[,] CreateAnUpperTriangularMatrix(int line, int column, int Mini, int Max)
        {
            int[,] X = DiagonalMatrix(line, column, Mini, Max);
            var rand = new Random();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = i; j < X.GetLength(1); j++)
                    X[i, j] = rand.Next(Mini, Max);

            }
            return X;
        }
        /// <summary>
        /// Alt üçgen matris oluşturun.
        /// Create a lower triangular matrix.
        /// </summary>
        /// <remarks>Bir üçgen matris, kare matris olmak zorundadır.</remarks>
        /// <param name="line">Line number</param>
        /// <param name="column">column number</param>
        /// <param name="Mini">Minimum value</param>
        /// <param name="Max">Max value</param>
        /// <returns>Symetric Matrix</returns>
        public static int[,] CreateAnLowerTriangularMatrix(int line, int column, int Mini, int Max)
        {
            int[,] X = DiagonalMatrix(line, column, Mini, Max);
            var rand = new Random();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                    X[i, j] = rand.Next(Mini, Max);

            }
            return X;
        }
        /// <summary>
        /// Parametre olarak aldigi matrisin ust ucgen matris olup olmadigi kontrol eder.
        /// </summary>
        /// <param name="X">Matrix </param>
        /// <remarks>Bir üçgen matris, kare matris olmak zorundadır.</remarks>
        /// <returns>True or false </returns>
        public static bool UpperTriangularMatrixControl(int[,] X)
        {
            bool s = true;
            for (int i = 1; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (!(X[i, j] == 0))
                    {
                        s = false
                            ;
                        break;
                    }
                }
            }
            return s;
        }
        /// <summary>
        /// Parametre olarak aldigi matrisin alt ucgen matris olup olmadigi kontrol eder.
        /// </summary>
        /// <param name="X">Matrix</param>
        /// <returns>True or false </returns>
        public static bool LowerTriangularMatrixControl(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = i + 1; j < X.GetLength(1); j++)
                {
                    if (!(X[i, j] == 0))
                    {
                        s = false
                            ;
                        break;
                    }
                }
            }
            return s;
        }



    }
}
