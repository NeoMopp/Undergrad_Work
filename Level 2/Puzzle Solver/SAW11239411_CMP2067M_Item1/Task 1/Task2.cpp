#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include"Matrix.h"
using namespace std;

void wheresWally()
{
	//Reads in Wally from txt file.
	char* filePath = "Wally_grey.txt";
	double* basIm = readTXT(filePath, 49,36);
	Matrix Wally(49,36,basIm);

	//Reads in background Image.
	char* filePath2 = "Cluttered_scene.txt";
	double* basIm2 = readTXT(filePath2, 768, 1024);
	Matrix Scene(768, 1024, basIm2);

	//Define additional Variables
	int blkM = 49;
	int blkN = 36;
	Matrix subScene(49,36);
	double score = -1.0;
	double bestScore = -3.0;
	double temp = 0;
	int x = 0;
	int y = 0;
	
	//Calculating the Score for Wally
	for (int ii = 0; ii <= 768 - blkM; ii++)
	{
		for (int jj = 0; jj <= 1024 - blkN; jj++)
		{
			
			subScene = Scene.getBlock(ii, (ii+blkM-1), jj, (jj+blkN-1));
			score = nC(Wally, subScene);
			if (score > bestScore)
			{
				bestScore = score;
				x = ii;
				y = jj;
			}

		}
	}

	//Loop to highlight Wally in the Image
		for (int jj = y; jj < y+blkN; jj++)
		{
			Scene.set(x,jj,temp);
			Scene.set(x+blkM, jj, temp);
		}

		for (int ii = x; ii < x+blkM; ii++)
		{
			Scene.set(ii,y,temp);
			Scene.set(ii,y+blkN,temp);
		}


	//Outputs the altered file
	char* newFile = "wallyFound.pgm";
	writePGM(newFile, Scene, 255);
	delete [] basIm;
	delete [] basIm2;
}