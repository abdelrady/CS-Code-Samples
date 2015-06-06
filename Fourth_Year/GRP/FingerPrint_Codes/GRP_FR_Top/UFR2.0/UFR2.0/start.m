% Main code for accessing the software
%Clears the parallel port first and then turns on(gives logical 1) 
%to D2


clc
clear all
close all
b=1;
for b=1:100
i=1;
k=1;
parport=digitalio('parallel','LPT1');
line=addline(parport,0:3,'out');
putvalue(parport,[0 0 1 0]);
end


putvalue(parport,[0 0 1 0]);
  gval = getvalue(parport);
  delete(parport);

h = waitbar(0,'Ultimate Face Recognition version 1.0.. LOADING.....');
for i=1:2450, 
waitbar(i/100)
end
close(h)
bdrfacerec