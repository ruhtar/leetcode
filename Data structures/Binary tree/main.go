package main

import "fmt"

func main() {
	fmt.Println("hello world")
}

struct BinaryTree {
	Node root
}

struct Node {
	int value
	Node leftNode	
	Node rightNode
}