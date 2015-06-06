% printing the list elements.
print1([]).
print1([H|T]):-	
	write(H),
	nl,
	print1(T).
%-----------------------------------------------
%multiplication alist with a number
operation(E,[],[]).
operation(E,[H|T],[M|T2]):-
	M is E*H,
	operation(E,T,T2).
%-----------------------------------------------
member(X,[X|_]).
member(X,[_|T]):-
	member(X,T).
%-------------------------------------------------
% Checking subset operation
subset([],_).
subset([H|T],L):-
	member(H,L),
	subset(T,L).
%--------------------------------------------------
equal(S1,S2):-
	subset(S1,S2),
	subset(S2,S1).
%--------------------------------------------------
% Calculating the intersection of two matrix
intersection([],_,[]).
intersection(_,[],[]).
intersection([H|T],L,[H|T2]):-
	member(H,L),
	intersection(T,L,T2).
intersection([H|T],L,L2):-
	\+member(H,L),
	intersection(T,L,L2).
%------------------------------------------------------
% deleting an element from list
del(_,[],[]).
del(E,[H|T],[NH|T2]):-
	E=\=H,
	NH=H,
	del(E,T,T2).
del(E,[H|T],L):-
	E=:=H,
	del(E,T,L).
%-----------------------------------------------------
% checking if all elements of alist are Digit or no
is_digit([E]):-
	E>=0,E=<9.
is_digit([H|T]):-
	H>=0,H=<9,
	is_digit(T).
%------------------------------------------------------
% calculating the list elements
sum([E],E).
sum([H|T],S):-
	sum(T,NS),
	S is H+NS.
%------------------------------------------------------
% display the list between two element
list_inr(E1,E2,L):-
	E1=<E2,
	lir(E1,E2,L).
list_inr(E1,E2,L):-
	E1>E2,
	lir(E2,E1,L).
lir(E1,E1,[E1]).
lir(E1,E2,[E1|T]):-
	E1<E2,
	E3 is E1+1,
	lir(E3,E2,T).
%-----------------------------------------------
% finding the minimum element in the list
min([E],E).
min([H|T],M):-
	min(T,NM),
	(H<NM,M is H;M is NM),!.
%-----------------------------------------------
%finding the maximum element in the list
return(X,[E]):-
	X=E.
return(X,[H|T]):-
	return(X,T).
max([E],E).
max([H|T],M):-
	max(T,M2),
	(H>M2,M is H;M is M2),!.
%-----------------------------------------------
% return the last element in the list
return(X,[E]):-
	X=E.
return(X,[H|T]):-
	return(X,T).
%-----------------------------------------------
 %Find the K'th element of a list. 
position(X,[X|_],1).
position(X,[_|L],K) :- 
	K > 1, 
	K1 is K - 1, 
position(X,L,K1).
%----------------------------------------------
merge(L,[],L).
merge([],L,L).
merge([H1|T1],[H2|T2],[H1|T3]):-
	H1<H2,
	merge(T1,[H2|T2],T3).
merge([H1|T1],[H2|T2],[H2|T3]):-
	H2<H1,
	merge([H1|T1],T2,T3).
%-----------------------------------------------
append([],L,L).
append([H|T],L,[H|R]):-
	append(T,L,R).
%-----------------------------------------------
reverse([],[]).
reverse([H|T],L):-
	reverse(T,R),
	append(R,[H],L).
%-----------------------------------------------
insert_at(E,L,1,[E|L]).
insert_at(E,[H|T],P,[H|NT]):-
	p>1,
	NP is p-1,
	insert_at(E,T,NP,NT).
%-----------------------------------------------
my_flatten(X,[X]) :- \+is_list(X).
my_flatten([],[]).
my_flatten([X|Xs],Zs) :- 
	my_flatten(X,Y),
	 my_flatten(Xs,Ys), 
	append(Y,Ys,Zs).
%-----------------------------------------------
%quick sort
quicksort([], []).
quicksort([X|Xs], Ys) :-
	partition(Xs, X, Littles, Bigs),
	quicksort(Littles, Ls),
	quicksort(Bigs, Bs),
	append(Ls, [X|Bs], Ys).
partition([], _, [], []).
partition([Y|Ys], X, [Y|Ls], Bs) :- 				      
	X>Y,
	partition(X, Ys, Ls, Bs).
	partition([Y|Ys], X, Ls, [Y|Bs]) :- 	
	X=<Y,
	partition(X, Ys, Ls, Bs).





