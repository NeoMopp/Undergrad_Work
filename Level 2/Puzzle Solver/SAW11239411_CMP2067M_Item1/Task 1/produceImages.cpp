#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include"Matrix.h"
using namespace std;


//Code to create all the images used as part of this Assignment, for documentaion purposes.
void prodImages()
{
	//Reads in Noisy Image
	char* filePath2 = "logo_with_noise.txt";
	double* basIm2 = readTXT(filePath2, 512, 512);
	Matrix logoWithNoise(512, 512, basIm2);
	cout<<"done"<<endl;

	//Reads in the Shuffled Image
	char* filePath = "logo_shuffled.txt";
	double* basIm = readTXT(filePath, 512, 512);
	Matrix logoShuffled(512, 512, basIm);
	cout<<"done"<<endl;

	//Reads in Wallys background Image
	char* filePath3 = "Cluttered_scene.txt";
	double* basIm3 = readTXT(filePath3, 768, 1024);
	Matrix Scene(768, 1024, basIm3);

	//Reads in Wally
	char* filePath4 = "Wally_grey.txt";
	double* basIm4 = readTXT(filePath4, 49,36);
	Matrix Wally(49,36, basIm4);

	//Define file Path Names and creates files
	char* newFile = "logoWithNoise.pgm";
	char* newFile2 = "logShuffled.pgm";
	char* newFile3 = "ClutteredScene.pgm";
	char* newFile4 = "Wally.pgm";
	writePGM(newFile, logoWithNoise, 255);
	writePGM(newFile2, logoShuffled, 255);
	writePGM(newFile3,Scene,255);
	writePGM(newFile4, Wally, 255);

	delete [] basIm;
	delete [] basIm2;
	delete [] basIm3;
	delete [] basIm4;

}
