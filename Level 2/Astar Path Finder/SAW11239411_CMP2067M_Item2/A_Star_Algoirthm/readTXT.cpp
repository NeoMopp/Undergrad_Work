#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include<iomanip>
#include"Methods.h"
using namespace std;

//Reads in file and from specified location and builds it
double* readTXT(char* fileName, int sizeR, int sizeC)
{
	double* input_data = new double[sizeR*sizeC];
	int i =0;
	ifstream currentFile(fileName);
	if (currentFile.is_open())
	{
		while(currentFile.good())
		{
			if (i>sizeR*sizeC-1) break;
			currentFile >> input_data[i];
			i++;
		}
		currentFile.close();
	}
	else
	{
		cout<<"File path not found"<<endl;
	}

	return input_data;
	delete [] input_data;

}
