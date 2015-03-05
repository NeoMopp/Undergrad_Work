function pX = clearBackground(model, pX)
%Code written by William Sawyer.
%Level 3 Computer Science
%For Assignment 1 of CMP3641M

%Removes Colours in the input image that exist in the colour model.
%-------------------------Code Begins Here--------------------------------
for i=1:1:1080
    for j=1:1:360
%Get the colour in the image        
        r = pX(i,j,1);
        g = pX(i,j,2);
        b = pX(i,j,3);
%Check to see if it's in the model, if it is set the pixel to black.        
        if model(r+1, g+1, b+1) == 1
            pX(i,j,1) = 0;
            pX(i,j,2) = 0;
            pX(i,j,3) = 0;
        end
    end
end
