append([],L,L).
append([H|T],L,[H|TT]):-
	append(T,L,TT).
get_list([H|_],1,[H]).
get_list([H|T],N,[H|TT]):-
	N>1,
	NN is N-1,
	get_list(T,NN,TT).
pre([],_,L,L).
pre(L1,N,L2,L3):-
	get_list(L1,N,L4),
	append(L4,L2,L3).

%------------------------------------------------------------------------------
get_Rlist([_|T],1,T).
get_Rlist([_|T],N,L):-
	N>1,
	NN is N-1,
	get_Rlist(T,NN,L).
sub([],_,L1,L1).
sub(L,N,L1,L2):-
	get_Rlist(L,N,L3),
	append(L3,L1,L2).


%-----------------------------------------------------------------------
f(a,b,c).
f(a,b,d).
f(b,c,d).
f(a,c,d).
g(a,b).
g(a,c).
g(b,d).
g(c,d).
h(X,Y,Z):-
	f(X,Y,Z),\+g(X,Y),g(Y,W).

%----------------------------------------------------------------------
