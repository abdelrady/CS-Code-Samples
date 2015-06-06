sub_tree(BT,BT).
sub_tree(BT,btree(_,LT,RT)):-
	sub_tree(BT,LT),
	sub_tree(BT,RT).
