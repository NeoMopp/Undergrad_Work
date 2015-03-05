function image = overlay(input, mask)
%Code written by William Sawyer.
%Level 3 Computer Science
%For Assignment 1 of CMP3641M

%Optimised from the function imoverlay written by Eddins S. 2013
%imoverlay found: http://www.mathworks.co.uk/matlabcentral/fileexchange/10502-image-overlay

%Overlays two images, where white exists in mask it is made blue in "image"
%--------------------------Code Begins Here--------------------------------
%Make mask logical
mask = (mask ~= 0);

%Convert everything to unit8
input_un8 = im2uint8(input);
colour_un8 = im2uint8([0,0,1]);

%Initialise colour channels
im_red = input_un8(:,:,1);
im_green = input_un8(:,:,2);
im_blue = input_un8(:,:,3);

%Replace colour in input with appropriate values
im_red(mask) = colour_un8(1);
im_green(mask) = colour_un8(2);
im_blue(mask) = colour_un8(3);

%Combine Colour channels
image = cat(3, im_red, im_green, im_blue);
end