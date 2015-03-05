function pX = getPotato(pX, model)
%Code written by William Sawyer.
%Level 3 Computer Science
%For Assignment 1 of CMP3641M

%Code used to detect potatoes in the provided images.
%-------------------------Code Begins Here--------------------------------

%Remove Background from image
plain_p = clearBackground(model, pX);
%figure, imshow(plain_p);

%Convert to greyscale, apply median filter and remove noise
p_gray = rgb2gray(plain_p);
%figure, imshow(p_gray);
med_p_gray = medfilt2(p_gray, [4,4]);
%figure, imshow(med_p_gray);
filt_p_gray = p_gray-med_p_gray;
%figure, imshow(filt_p_gray);
clean_p_gray = p_gray - filt_p_gray;
%figure, imshow(clean_p_gray);

%Convert to Binary
p_binary = im2bw(clean_p_gray, 0.015);
%figure, imshow(p_binary);

%Remove some noise from the binary image making it clearer and easier to
%overlay
p_binary = bwareaopen(p_binary, 500);
%figure, imshow(p_binary);
p_fill = imfill(p_binary, 'holes');
%figure, imshow(p_fill);
se = strel('disk', 2);
p_erode = imdilate(p_fill, se);
%figure, imshow(p_erode);

%Invert binary, lets overlay work better.
p_erode = imcomplement(p_erode);
%figure, imshow(p_erode);
%Overlay inverted binary image on original
p_complete = overlay(pX, p_erode);
figure, imshow(p_complete);
end






