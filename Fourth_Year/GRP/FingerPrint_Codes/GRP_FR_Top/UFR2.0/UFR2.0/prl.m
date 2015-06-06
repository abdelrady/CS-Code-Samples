% This code gives logical 0 1 0 1 to parrallel port.
% Waits a moment and gives logical 0 0 1 0 (values at start.m)


z=1;
for z=1:500
i=1;
k=1;
parport=digitalio('parallel','LPT1');
line=addline(parport,0:3,'out');
putvalue(parport,[0 1 0 1]);
end


putvalue(parport,[0 0 1 0]);
  gval = getvalue(parport);
 



