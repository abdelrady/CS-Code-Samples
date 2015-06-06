%This code arranges the size of mean face and eigenfaces

%Author:Alex Chirokov
%Available at
% http://www.mathworks.com/matlabcentral/fileexchange/loadFile.do?objectId=6995&objectType=file

function out=ScaleImage(in)
in_min=min(min(in));
in_max=max(max(in));

out = (in-in_min)/ (in_max-in_min);

