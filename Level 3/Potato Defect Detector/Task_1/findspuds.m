function [] = findspuds( image_in )
%Code written by William Sawyer.
%Level 3 Computer Science
%For Assignment 1 of CMP3641M

%This code intends to analyse the input image, which contains potatoes, and
%output a number of details of said input.
%The required outputs are:
%-Location of the Centoid (of each object in the image).
%-Size of object.
%-Length of Major and Minor axes of object.
%-The objects circularity.
%-Mean and standard deviation of R,G,B colour values in the image.

%--------------------------Code Begins Here--------------------------------

%Input Image read in and stored in "f".
f = imread(image_in);
%figure, imshow(f)

%Convert input image to "Gray", store in f_gray.
f_gray = rgb2gray(f);
%figure, imshow(f_gray)

%Apply median filter to remove noise.
med_f_gray = medfilt2(f_gray, [4,4]);
%figure, imshow(med_f_gray)

%This section may be useless, keeping it just incase.
%Some alterations to clean up the image.
filt_f_gray = f_gray-med_f_gray;
%figure, imshow(filt_f_gray);
clean_f_gray = f_gray - filt_f_gray;
%figure, imshow(clean_f_gray);

%This value causes quite a bit of trouble, alot of trial and error here.
f_binary = im2bw(clean_f_gray, 0.05);
%figure, imshow(f_binary);

%Fill any areas of black surrounded by white, i.e. spots drawn on by
%others.
f_fill = imfill(f_binary, 'holes');
%figure, imshow(f_fill);

%Disk was chosen as it provided the "smoothest" result
se = strel('disk', 2);
%Erode to try smooth edges, erode used as it produced the best result
f_erode = imerode(f_fill, se);
%figure, imshow (f_erode);

%Label the potatoes in the images.
[L, num] = bwlabel(f_erode, 8);

%Make the highlight image
outline_f = imdilate(f_erode, se) - f_erode;
%figure, imshow(outline_f);

%Using the function written by ____ overlay the images.
final_f = overlay(f, outline_f);
figure, imshow(final_f);
%Outputting necessary information

disp('Number of Potatoes');
disp(num);

props = regionprops(L,'All');
disp('                   Potato Centroid                                                                               Mean                  Standard Deviation');
disp('Potato Number      X          Y        Num of Pixels    MajorAxisLength   MinorAxisLength  circularity      R      G      B            R       G       B');
for x = 1:1:numel(props),
    x_coord = props(x).Centroid(1);
    y_coord = props(x).Centroid(2);
    pixel = props(x).Area;
    major = props(x).MajorAxisLength;
    minor = props(x).MinorAxisLength;
    circ = (4*pi*pixel)/(props(x).Perimeter^2);
    [R,G,B, stdR, stdG, stdB] = getMean(props(x), f);
    info = ['\t',num2str(x),'\t\t\t', num2str(x_coord,'%07.3f'), '\t\t', num2str(y_coord,'%07.3f'), '\t\t',num2str(pixel,'%09.3f'), '\t\t\t', num2str(major,'%07.3f'), '\t\t\t', num2str(minor,'%07.3f'), ' \t\t ', num2str(circ,'%05.3f'), '\t\t', num2str(R,'%07.3f'), '\t', num2str(G,'%07.3f'), '\t', num2str(B,'%07.3f'),'\t\t', num2str(stdR,'%07.3f'),'\t',num2str(stdG,'%07.3f'), '\t', num2str(stdB,'%07.3f'), '\n'];
    fprintf(info);

end

