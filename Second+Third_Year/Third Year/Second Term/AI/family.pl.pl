parent(ali,mohmed).
parent(ali,hossam).
parent(ali,ahmad).
parent(hoda,heba).
parent(hosam,yussra).
parent(hosam,hassan).
%---------------------------------------
wife(nagwa,ali).
wife(hoda,mohamed).
wife(alia,hosam).
%----------------------------------------
grandfather(ali,heba).
grandfather(ali,yussra).
grandfather(ali,hassan).
%-----------------------------------------
male(ali).
male(ahmad).
male(mhmed).
male(hosam).
male(hassam).
%-------------------------------------------
female(nagwa).
female(alia).
female(hoda).
female(heba).
female(yussra).
%-----------------------------------------
brother(X,Y):-
	parent(Z,X),
	parent(Z,Y),
	male(X).
%-----------------------------------------
sister(X,Y):-
	parent(Z,X),
	parent(Z,Y),
	female(X).
%-------------------------------------------
grandfather(X,Y):-
	parent(Z,X),
	parent(X,Y).
%-------------------------------------------
son(X,Y):-
	parent(Y,X).