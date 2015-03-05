#pragma
#ifndef MATRIX_H
#define MATRIX_H

class Matrix
{
protected:
	int M;
	int N; 
	double* data;
	Matrix(){M = 0; N = 0;data = 0;}												//Constructor to avoid error

public:
	
	Matrix(int sizeR, int sizeC, double* input_data);								//Constructor
	Matrix(int sizeR, int sizeC);
	~Matrix();																		//Destructor
	Matrix(const Matrix& existingMatrix);											//Copy Constructor
	double get (int i , int j)	const;												//Returns value at specified location
	const void set(int i, int j, double& val);										//Changes value at specified location
	int getM() const;																//Return value of M
	int getN() const;																//Return value of N
	Matrix getBlock(int startRow, int endRow, int startColumn, int endColumn);		//Return section of Matrix
	Matrix operator + (const Matrix& B);											//Allows for operator Overloading of addition
	Matrix& operator = (const Matrix& B);											//Allows for operator Overloading of equals
	Matrix operator - (const Matrix& B);											//Allows for operator Overloading of minus
	Matrix operator * (const Matrix& B);											//Allows for operator Overloading of multiplication
	Matrix operator / (const Matrix& B);											//Allows for operator Overloading of division
	Matrix& operator ++ ();															//Allows for operator Overloading of increment
	double operator () (int i, int j);												//Allows for indirect calling of the get() function
	void out();																		//Ouput the Matrix to console
	double Sum();																	//Returns the sum of the Matrix 
};

class BinaryImage
	:public Matrix
{

private:
	double threshold;
	BinaryImage():Matrix(){threshold = 0;}										//Constructor to Avoid error

public:
	BinaryImage(int sizeR, int sizeC, double* input_data, double thresh);		//Constructor
	BinaryImage(const Matrix& rhs, double thresh);								//Constructor
	BinaryImage(const BinaryImage& existingBinIm);								//Constructor
	BinaryImage(int sizeR, int sizeC);											//Constructor
	double getThresh() const;													//Returns Threshold
	const void set(int i, int j, double& val);									//Sets value
	BinaryImage operator + (const BinaryImage& B);								//Operation Overloading
	BinaryImage operator - (const BinaryImage& B);								//Operation Overloading
	BinaryImage operator * (const BinaryImage& B);								//Operation Overloading
	BinaryImage& operator = (const BinaryImage& B);								//Operation Overloading
	Matrix toMat();																//Converts Binary Image to Matrix.
};

void shuffledLogo();															//Task 1
void wheresWally();																//Task 2
void prodImages();																//Outputs the image that are used, for documentation
void shuffledBinary();															//Task 1 with Binary
double* readTXT(char* fileName, int sizeR, int sizeC);							//George's code
void writePGM(char* fileName, Matrix& toWrite, int Q);							//George's code
double sSD(Matrix& A, Matrix& B);												//Calculates Sum of Squared Differences
double sSD(BinaryImage& A, BinaryImage& B);										//Calculates Sum of Squared Differences for Binary
double nC(Matrix& A, Matrix& B);												//Calculates Normalized Correlation

#endif