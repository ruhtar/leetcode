package main

import "fmt"

type Node struct {
	LeftChild  *Node
	RightChild *Node
	Data       int64
}

func main() {
	rootNode := &Node{
		LeftChild:  nil,
		RightChild: nil,
		Data:       2,
	}

	fmt.Println(rootNode.Data)
}
