%Checking the image before adding to database.
%Checks if the image is selected or not
clc
h = waitbar(0,'CHECKING.....');
for i=1:1450, 
waitbar(i/100)

end
close(h)
if exist('img')
   dataaddtest
else
   h = waitbar(0,'No image has been selected Please Wait.....');
for i=1:3450, 
waitbar(i/100)

end
close(h)
   
   
    bdrfacerec
    
end
