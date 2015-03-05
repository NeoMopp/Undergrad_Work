function Task2()
%Code written by William Sawyer.
%Level 3 Computer Science
%For Assignment 1 of CMP3641M

%This code intends to create a background mask using the images provided by
%the assignment to allow for potoato detection on a non-consistent background.
%The code should create a model using 4 images and then analyse the
%potatoes in remaining 11 images.

%-------------------------Code Begins Here--------------------------------

%Read in background images to build model
b1 = imread('beltempty_1.jpg');
b2 = imread('beltempty_2.jpg');
b3 = imread('beltempty_3.jpg');
b4 = imread('beltempty_4.jpg');

%Read in the images containing potatoes.
p1 = imread('beltpotatoes_1.jpg');
p2 = imread('beltpotatoes_2.jpg');
p3 = imread('beltpotatoes_3.jpg');
p4 = imread('beltpotatoes_4.jpg');
p5 = imread('beltpotatoes_5.jpg');
p6 = imread('beltpotatoes_6.jpg');
p7 = imread('beltpotatoes_7.jpg');
p8 = imread('beltpotatoes_8.jpg');
p9 = imread('beltpotatoes_9.jpg');
p10 = imread('beltpotatoes_10.jpg');
p11 = imread('beltpotatoes_11.jpg');

%Create background mask
%imfuse creates a "confused image" use own function instead.
%First make empty Matrix to hold the model.
model = zeros(255,255,255);
model = buildModel(b1, model);
model = buildModel(b2, model);
model = buildModel(b3, model);
model = buildModel(b4, model);

%Start getting the potatoes out of the images
getPotato(p1, model);
getPotato(p2, model);
getPotato(p3, model);
getPotato(p4, model);
getPotato(p5, model);
getPotato(p6, model);
getPotato(p7, model);
getPotato(p8, model);
getPotato(p9, model);
getPotato(p10, model);
getPotato(p11, model);
end

