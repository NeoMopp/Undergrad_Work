function model = buildModel(bg, model)
%Code written by William Sawyer.
%Level 3 Computer Science
%For Assignment 1 of CMP3641M

%This section of code is used to learn the background's colour model

%-------------------------Code Begins Here--------------------------------
%Obtain the size of the image to know how to loop
[x,y,z] = size(bg);
% loop though each image
    for i=1:1:x,
        for j=1:1:y,
%Model is built, each colour that exists in the input is added to the model
            r = bg(i,j,1);
            g = bg(i,j,2);
            b = bg(i,j,3);
%Where the model is true the colour exists where it is false it doesn't
            model(r+1,g+1,b+1) = 1;
        end
    end

%Apply some smoothing to try and even out the colour, helps with
%subtraction.
SE = strel('square', 2);
model = imdilate(model,SE);
end

 


