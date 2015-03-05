#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include <iomanip>
#include"Matrix.h"
using namespace std;

//Task 1 without using Binary
void shuffledLogo()
{
	//Reads in Origingal Image - note is distorted.
	char* filePath2 = "logo_with_noise.txt";
	double* basIm2 = readTXT(filePath2, 512, 512);
	Matrix logoWithNoise(512, 512, basIm2);
	
	//Reads in the Shuffled Image.
	char* filePath = "logo_shuffled.txt";
	double* basIm = readTXT(filePath, 512, 512);
	Matrix logoShuffled(512, 512, basIm);

	//Define additional variables.
	Matrix logoUnshuffled(512,512);														//Matrix to hold the final image.
	long double Score = 0.0;															//Current "Pixels" score.
	long double bestScore = 0.0;														//Best "Pixel" score.
	bool bestOrig = true;																//Check, if true then first time with this "Pixel".
	
	//The size of the "Pixels".
	int blkSize = 32;																	

	//Creating temporary Matricies to hold the "Pixel".
	Matrix subWithNoise(blkSize, blkSize);
	Matrix subShuffled(blkSize, blkSize);
	Matrix best(blkSize, blkSize);

	//Define additional Variables to prevent same "Block" being used.
	int bestX = 0;
	int bestY = 0;
	bool* localBools = new bool [256];
	for (int i = 0; i < 256; i++)
	{
		localBools[i] = false;
	}
	

	//For Loop to begin Sum of Squared Differences.
	//Unjumbled image.
	for (int x = 0; x <= (512-blkSize); x+=blkSize)
	{	
		for (int y = 0; y <= (512-blkSize); y += blkSize)
		{
			subWithNoise = logoWithNoise.getBlock(x,(x+blkSize-1),y,(y+blkSize-1));			
			//Jumbled Image
			for (int xx = 0; xx <= (512-blkSize); xx+=blkSize)
			{
				for (int yy = 0; yy <= (512-blkSize); yy+=blkSize)
				{
					//Checks to see if a "Block" has already been used for the final image.
					if( localBools[(xx/32)*16+(yy/32)] == false)
					{
						//Calculating the Score starts here.
						subShuffled = logoShuffled.getBlock(xx,xx+blkSize-1, yy, yy+blkSize-1);
						Score = sSD(subWithNoise, subShuffled);
					
						//If bestOrig is true then changes bestScore.
						if (bestOrig == true)
						{
							bestScore =  Score;
							best = subShuffled;
							bestOrig = false;
							bestX = xx;
							bestY = yy;
						}
						//Checks to see if Score is better than the bestScore. Smaller is better.
						if (Score <  bestScore)
						{
							bestScore = Score;
							best = subShuffled;
							bestOrig = false;
							bestX = xx;
							bestY = yy;
						}
					}

					//If the "Block" has been used skips the current iteration.
					else 
					{
						continue;
					}
				}
			}

			//For loop to put the best option into the final Matrix.
			for (int m = 0; m < blkSize; m++)
			{
				for (int n = 0; n < blkSize; n++)
				{
					double temp = best.get(m,n);
					logoUnshuffled.set(x+m, y+n, temp);
				}
			}
			bestOrig = true;
			bestScore = 0.0;

			//Adds to check Array to ensure that nothings used twice.
			localBools[(bestX/32)*16+(bestY/32)] = true;
		}
		//Calculate % complete
		double percent = (x*100)/512;
		cout<<"Percent complete: "<< percent <<endl;
	}
	cout<<"Image reorganisation complete..."<<endl<<"Producing output file.."<<endl;
	
	//Creates file.
	char* newFile = "logoUnShuffled.pgm";
	writePGM(newFile, logoUnshuffled, 255);
	delete [] basIm;
	delete [] basIm2;

}


//Task 1 with Binary
void shuffledBinary()
{
	//Reads in Origingal Image - note is distorted.
	char* filePath2 = "logo_with_noise.txt";
	double* basIm2 = readTXT(filePath2, 512, 512);
	BinaryImage binWithNoise(512, 512, basIm2,150);
	//Converts BinaryImage back to Matrix
	Matrix logoWithNoise = binWithNoise.toMat();

	//Reads in the Shuffled Image.
	char* filePath = "logo_shuffled.txt";
	double* basIm = readTXT(filePath, 512, 512);
	BinaryImage binShuffled(512, 512, basIm, 150);
	//Converts BinaryImage back to Matrix
	Matrix logoShuffled = binShuffled.toMat();

	//Define additional variables.
	Matrix logoUnshuffled(512,512);														//Matrix to hold the final image.
	long double Score = 0.0;															//Current "Pixels" score.
	long double bestScore = 0.0;														//Best "Pixel" score.
	bool bestOrig = true;																//Check, if true then first time with this "Pixel".

	//The size of the "Pixels".
	int blkSize = 32;																	

	//Creating temporary Matricies to hold the "Pixel".
	Matrix subWithNoise(blkSize, blkSize);
	Matrix subShuffled(blkSize, blkSize);
	Matrix best(blkSize, blkSize);

	//Define additional Variables to prevent same "Block" being used.
	int bestX = 0;
	int bestY = 0;
	bool* localBools = new bool [256];
	for (int i = 0; i < 256; i++)
	{
		localBools[i] = false;
	}
	

	//For Loop to begin Sum of Squared Differences.
	//Unjumbled image.
	for (int x = 0; x <= (512-blkSize); x+=blkSize)
	{	
		for (int y = 0; y <= (512-blkSize); y += blkSize)
		{
			subWithNoise = logoWithNoise.getBlock(x,(x+blkSize-1),y,(y+blkSize-1));			
			//Jumbled Image
			for (int xx = 0; xx <= (512-blkSize); xx+=blkSize)
			{
				for (int yy = 0; yy <= (512-blkSize); yy+=blkSize)
				{
					//Checks to see if a "Block" has already been used for the final image.
					if( localBools[(xx/32)*16+(yy/32)] == false)
					{
						//Calculating the Score starts here.
						subShuffled = logoShuffled.getBlock(xx,xx+blkSize-1, yy, yy+blkSize-1);
						Score = sSD(subWithNoise, subShuffled);
					
						//If bestOrig is true then changes bestScore.
						if (bestOrig == true)
						{
							bestScore =  Score;
							best = subShuffled;
							bestOrig = false;
							bestX = xx;
							bestY = yy;
						}
						//Checks to see if Score is better than the bestScore. Smaller is better.
						if (Score <  bestScore)
						{
							bestScore = Score;
							best = subShuffled;
							bestOrig = false;
							bestX = xx;
							bestY = yy;
						}
					}

					//If the "Block" has been used skips the current iteration.
					else 
					{
						continue;
					}
				}
			}

			//For loop to put the best option into the final Matrix.
			for (int m = 0; m < blkSize; m++)
			{
				for (int n = 0; n < blkSize; n++)
				{
					double temp = best.get(m,n);
					logoUnshuffled.set(x+m, y+n, temp);
				}
			}
			bestOrig = true;
			bestScore = 0.0;

			//Adds to check Array to ensure that nothings used twice.
			localBools[(bestX/32)*16+(bestY/32)] = true;
		}
		//Calculate % complete
		double percent = (x*100)/512;
		cout<<"Percent complete: "<< percent <<endl;
	}
	cout<<"Image reorganisation complete..."<<endl<<"Producing output file.."<<endl;
	
	//Creates file.
	char* newFile = "logoUnShuffledBin.pgm";
	writePGM(newFile, logoUnshuffled, 1);
	delete [] basIm;
	delete [] basIm2;

}
