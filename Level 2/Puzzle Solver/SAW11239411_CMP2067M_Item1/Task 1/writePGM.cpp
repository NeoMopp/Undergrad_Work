#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include"Matrix.h"
using namespace std;

void writePGM(char* fileName, Matrix& toWrite, int Q)
{
	int x = toWrite.getM();
	int y = toWrite.getN();
	unsigned char *image;
	ofstream myfile;

	image = (unsigned char *) new unsigned char [x*y];

	// convert the integer values to unsigned char

	for(int i = 0; i<x; i++)
	{
		for (int j = 0; j<y; j++)
		{
			image[i*y+j]=(unsigned char)toWrite.get(i,j);
		}
	}

	myfile.open(fileName, ios::out|ios::binary|ios::trunc);

	if (!myfile) 
	{
		cout << "Can't open file: " << fileName << endl;
		exit(1);
	}

	myfile << "P5" << endl;
	myfile << y << " " << x << endl;
	myfile << Q << endl;

	myfile.write( reinterpret_cast<char *>(image), (x*y)*sizeof(unsigned char));

	if (myfile.fail()) 
	{
		cout << "Can't write image " << fileName << endl;
		exit(0);
	}

	myfile.close();

	delete [] image;
}