function [R,G,B, stdR, stdG, stdB ] = getMean(section, RGB_image)
%Code written by William Sawyer.
%Level 3 Computer Science
%For Assignment 1 of CMP3641M
%This code calculates the Mean and Standard Deviation of the input.
%--------------------------Code Begins Here--------------------------------

%Ensure RGB values are empty by assigning 0, may be uneeded but better to be
%safe than sorry.
R = 0; 
G = 0; 
B = 0; 

%Get the Location and size of the object.
col = section.PixelList(:,2);
row = section.PixelList(:,1);

%Calculating the mean here.
pixels = impixel(RGB_image, row, col); 
R = (mean(pixels(:,1)));
G = (mean(pixels(:,2)));
B = (mean(pixels(:,3)));

%Calculating the Standard Deviation here.
stdR = std(pixels(:,1));
stdG = std(pixels(:,2));
stdB = std(pixels(:,3));


end

