package main

import "fmt"

type BinaryTree struct {
	RootNode *Node
}

type Node struct {
	LeftChild  *Node
	RightChild *Node
	Data       int64
}

func main() {
	var bt BinaryTree

	bt.Insert(200)
	bt.Insert(150)
	bt.Insert(250)
	bt.Insert(170)
	bt.Insert(130)

	printTree(bt.RootNode, "", true)
}

func (bt *BinaryTree) Insert(data int64) *BinaryTree {
	if bt.RootNode == nil {
		bt.RootNode = &Node{
			LeftChild:  nil,
			RightChild: nil,
			Data:       data,
		}
	} else {
		bt.add(data, bt.RootNode)
	}

	return bt
}

func (b *BinaryTree) add(data int64, node *Node) {
	if b.RootNode.Data > data && b.RootNode.LeftChild == nil {
		b.RootNode.LeftChild = &Node{
			Data:       data,
			RightChild: nil,
			LeftChild:  nil,
		}
		return
	} else if b.RootNode.Data < data && b.RootNode.RightChild == nil {
		b.RootNode.RightChild = &Node{
			Data:       data,
			RightChild: nil,
			LeftChild:  nil,
		}
		return
	}

	if node.Data < data && node.RightChild == nil {
		node.RightChild = &Node{
			Data:       data,
			RightChild: nil,
			LeftChild:  nil,
		}
		return
	}

	if node.Data > data && node.LeftChild == nil {
		node.LeftChild = &Node{
			Data:       data,
			RightChild: nil,
			LeftChild:  nil,
		}
		return
	}

	if node.Data > data {
		b.add(data, node.LeftChild)
	} else {
		b.add(data, node.RightChild)
	}
}

func printTree(node *Node, prefix string, isLeft bool) {
	if node == nil {
		return
	}

	fmt.Printf("%s", prefix)
	if isLeft {
		fmt.Print("L── ")
		prefix += "L    "
	} else {
		fmt.Print("R── ")
		prefix += "R    "
	}
	fmt.Println(node.Data)

	printTree(node.LeftChild, prefix, true)
	printTree(node.RightChild, prefix, false)
}
