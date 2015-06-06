is_btree(btree(_,void ,void)).
is_btree(btree(Key,LBT,RBT)):-
	test_left(Key,LBT),
	test_right(Key,RBT),
	is_btree(LBT),
	is_btree(RBT).
%-----------------------------------------
test_left(Key,btree(LK,_,_)):-
	Key>LK,
	test_left(_,void).
%------------------------------------------
test_rigth(Key,btree(RK,_,_)):-
	Key<LK,
	test_rigth(_,void).
%-------------------------------------------
member_tree(X,tree(X,_,_)).
member_tree(X,tree(_,Left,_)):-
	member(X,Left).
member_tree(X,tree(_,_,Right)):-
	member_tree(X,Right).
%-------------------------------------------

