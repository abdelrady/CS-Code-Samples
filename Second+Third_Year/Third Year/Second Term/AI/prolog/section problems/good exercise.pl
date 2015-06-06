p(1).
p(2):-!.
p(3).
% check the following cases
% 	 p(X).
%	 p(X),p(Y).
%	 p(X),!,p(Y).
%----------------------------------------------
% this program classificate the numbers into positive,negative mZero
class(N,0):- N=0.
class(N,P):-N>0,!.
class(N,Y).