#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include <iomanip>
#include"Matrix.h"
using namespace std;

//Consructor
Matrix::Matrix(int sizeR, int sizeC, double* inputData)
{
	M = sizeR;
	N = sizeC;
	data = new double [M*N];
	for (int ii = 0; ii < M*N; ii++)
	{
		data[ii] = inputData[ii];
	}
}

//Constructor
Matrix::Matrix(int sizeR, int sizeC)
{
	M = sizeR;
	N = sizeC;
	data = new double [M*N];

	for (int ii = 0; ii < M*N; ii++)
	{
		data[ii] = 0;
	}
}

//Destructor
Matrix::~Matrix()
{
	delete [] data;
}

//Copy Constructor
Matrix::Matrix(const Matrix& existingMatrix)
{
	M = existingMatrix.getM();
	N = existingMatrix.getN();
	data = new double[M*N];

	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			data[ii*N+jj] = existingMatrix.get(ii,jj);
		}
	}
}

//Pass by constant value
double Matrix::get (int i , int j)	const	
{
	return data[i*N + j];
}

//Pass by Refrence
const void Matrix::set(int i, int j, double& val)
{
	data[i*N + j] = val;
}

//Return Value of M
int Matrix::getM() const
{
	return M;
}

//Return Value of N
int Matrix::getN() const
{
	return N;
}

//Return Section of the Matrix.
Matrix Matrix::getBlock(int startRow, int endRow, int startColumn, int endColumn)
{
	int Row = endRow-startRow + 1;
	int Column =  endColumn - startColumn + 1;
	Matrix t(Row, Column);	
	for (int ii = 0; ii < Row; ii++)
	{
		for (int jj = 0; jj < Column; jj++)
		{
			double val = data[(ii+startRow)*N+(jj+ startColumn)];
			t.set(ii,jj, val); 
		}
	}

	return t;
}

//Allows for addion of Matricies, Operation Overloading.
Matrix Matrix::operator +(const Matrix& B)
{
	Matrix C(M, N);
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			double temp = data[ii*N+jj] + B.get(ii,jj);
			C.set(ii,jj, temp);
		}
	}

	return C;
}

//Makes x and y equal, Opperation Overloading.
Matrix& Matrix::operator =(const Matrix& B)
{
	if (this == &B)
	{
		return *this;
	}

	else 
	{
		M = B.getM();
		N = B.getN();
		delete [] data;
		data = new double [M*N];
		for (int ii = 0; ii < M; ii++)
		{
			for (int jj = 0; jj < N; jj++)
			{
				double temp = B.get(ii,jj);
				data[ii*N+jj] = temp;	
			}
		}
		return *this;
	}
}

//Allows for subtraction of matricies, Operation Overloading.
Matrix Matrix::operator -(const Matrix& B)
{
	Matrix C(M, N);
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			double temp = data[ii*N+jj] - B.get(ii,jj);
			C.set(ii,jj, temp);
		}
	}
	return C;
}

//Allows for multiplication of Matricies, Operation Overloading.
Matrix Matrix::operator *(const Matrix& B)
{
	Matrix C(M,N);
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			double temp = data[ii*N+jj] * B.get(ii,jj);
			C.set(ii,jj, temp);
		}
	}

	return C;
}

//Allows for addition of Matricies, Operation Overloading.
Matrix Matrix::operator /(const Matrix& B)
{
	Matrix C(M, N);
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			double temp = data[ii*N+jj] / B.get(ii,jj);
			C.set(ii,jj, temp);
		}
	}

	return C;
}

//Incrmentation of all values in Matrix by 1, Operation Overloading.
Matrix& Matrix::operator ++()
{
	for (int ii = 0; ii < M*N; ii++)
	{
		data[ii] = data[ii]++;
	}

	return *this;
}


//Allows calling of "get" function indirectly.
double Matrix::operator() (int i, int j)
{
	return data[i*N+j];
}

//Calculates the sum of the entire Matrix.
double Matrix::Sum()
{
	double total = 0.0;
	for (int ii = 0; ii < M*N; ii++)
	{
		total = total + data[ii];
	}
	return total;
}

//Allows for the output of a Matrix to the console.
void Matrix::out()
{
	for (int ii = 0; ii < M*N; ii++)
	{
		cout<<data[ii]<<" ";
	}
}

////////////////////////////////////////////- Binary Image Implementation - ////////////////////////////////////////////////////////


//Consructor
BinaryImage ::BinaryImage(int sizeR, int sizeC, double*input_data, double thresh)
	:Matrix(sizeR, sizeC, input_data)
{
	threshold = thresh;
	
	for(int ii = 0; ii < M*N; ii++)
	{
		if (data[ii] > threshold)
		{
			data[ii] = 1;
		}

		else 
		{
			data[ii] = 0;
		}
	}
}

//Consructor
BinaryImage::BinaryImage(const Matrix& rhs, double thresh)
	:Matrix(rhs)
{
	threshold = thresh;

	for(int ii = 0; ii < M*N; ii++)
	{
		if (data[ii] > thresh)
		{
			data[ii] = 1;
		}

		else 
		{
			data[ii] = 0;
		}
	}

}

//Consructor
BinaryImage::BinaryImage(const BinaryImage& rhs)
{
	M = rhs.getM();
	N = rhs.getN();
	threshold = rhs.getThresh();
	data = new double[M*N];
	for (int ii = 0; ii<M; ii++)
	{
		for (int jj = 0; jj<N; jj++)
		{
			data[ii] = rhs.get(ii, jj);
		}
	}
}

//Consructor
BinaryImage ::BinaryImage(int sizeR, int sizeC)
	:Matrix(sizeR, sizeC)
{
	threshold = 150;
}

//Returns threshold
double BinaryImage::getThresh() const
{
	return threshold;
}

//Sets BinaryImage value
const void BinaryImage::set(int i, int j, double& val)
{
	int k = i*N + j;
	if (val > threshold)
	{
		data[k] = 1;
	}

	else 
	{
		data[k] = 0;
	};
}

//Logical OR
BinaryImage BinaryImage::operator + (const BinaryImage& B)
{
	Matrix C(M,N);
	double one = 1.0;
	double zero = 0.0;
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			if ((data[ii*N+jj] == 1) || (B.get(ii,jj) == 1))
			{
				C.set(ii,jj,one);
			}

			else 
			{
				C.set(ii,jj,zero);
			}
		}
	}
	BinaryImage D(C, 0);
	return D;
}

//Logical XOR
BinaryImage BinaryImage::operator - (const BinaryImage& B)
{
	Matrix C(M,N);
	double one = 1.0;
	double zero = 0.0;
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			if (data[ii*N+jj] != B.get(ii,jj) == 0)
			{
				C.set(ii,jj,one);
			}

			else 
			{
				C.set(ii,jj,zero);
			}
		}
	}
	BinaryImage D(C, 0);
	return D;
}

//Logical AND
BinaryImage BinaryImage::operator * (const BinaryImage& B)
{
	Matrix C(M,N);
	double one = 1.0;
	double zero = 0.0;
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			if (data[ii*N+jj] == B.get(ii,jj))
			{
				C.set(ii,jj,one);
			}

			else 
			{
				C.set(ii,jj,zero);
			}
		}
	}

	BinaryImage D(C, 0);
	return D;
}

//Equals Operator
BinaryImage& BinaryImage::operator = (const BinaryImage& B)
{
	if (this == &B)
	{
		return *this;
	}

	else 
	{
		M = B.getM();
		N = B.getN();
		threshold = B.getThresh();
		delete [] data;
		data = new double [M*N];
		for (int ii = 0; ii < M; ii++)
		{
			for (int jj = 0; jj < N; jj++)
			{
				double temp = B.get(ii,jj);
				data[ii*N+jj] = temp;	
			}
		}
		return *this;
	}
}

//Converts BinaryImage to Matrix
Matrix BinaryImage ::toMat()
{
	Matrix C(M,N);
	for (int ii = 0; ii < M; ii++)
	{
		for (int jj = 0; jj < N; jj++)
		{
			double temp = data[ii*N+jj];
			C.set(ii,jj,temp);
		}
	}
	return C;
}
