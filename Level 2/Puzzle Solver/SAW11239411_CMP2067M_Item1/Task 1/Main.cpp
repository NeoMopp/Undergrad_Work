#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include <iomanip>
#include"Matrix.h"
using namespace std;

int main()
{
	int selection;
	cout<<"Select a program to run:"<<endl<<"1 - Logo Reorganisation"<<endl<<"2 - Where's Wally"<<endl<<"3 - Produce PGM files of Images"<<endl<<"4 - Logo Reorganisation Binary"<<endl<<"Selection: ";
	cin>>selection;
	cout<<endl;
	//Selction to see what the user whats todo.
	switch(selection)
	{
	case 1:
		cout<<"Logo Reorganisation Commencing..."<<endl;
		shuffledLogo();
		break;
	case 2:
		cout<<"Where's Wally Commencing..."<<endl;
		wheresWally();
		break;
	case 3:
		cout<<"Producing PGM files..."<<endl;
		prodImages();
		break;
	case 4:
		cout<<"Binary reorganisation commencing"<<endl;
		shuffledBinary();
		break;
	default:
		cout<<"Selection invalid"<<endl;
		break;
	}
	Sleep(1000);
	return 0;
}

double sSD(Matrix& A, Matrix& B)
{
	Matrix diff(A.getM(),B.getN());
	Matrix product(A.getM(),B.getN());
	diff = A - B;
	product = diff*diff;
	double sSD = product.Sum();
	return sSD;
}


double nC(Matrix& A, Matrix& B)
{
	double N = 1764;
	double sumT = 331087;
	double sumSqT = 71207863;

	double sumI = B.Sum();
	Matrix IT = A*B;
	double sumIT = IT.Sum();
	Matrix SqI = B*B; 
	double sumSqI = SqI.Sum();


	double Numerator = (N*sumIT- sumI*sumT);
	double Denominator = (N*sumSqI - sumI*sumI)*(N*sumSqT - sumT*sumT);

	double nC = Numerator / sqrt(Denominator);
	return nC;
}