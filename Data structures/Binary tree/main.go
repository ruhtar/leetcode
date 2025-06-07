package main

import "fmt"

type Node struct {
	value     int
	leftNode  *Node
	rightNode *Node
}

func main() {
	bt := Node{}
	bt.insert(1)
	bt.insert(2)
	bt.insert(3)
	bt.insert(4)
	bt.insert(5)
	bt.insert(6)
	bt.insert(7)

	printBt(&bt)
}

func (n *Node) insert(value int) {
	if n.leftNode == nil {
		n.leftNode = &Node{
			value: value,
		}
		return
	}

	if n.rightNode == nil {
		n.rightNode = &Node{
			value: value,
		}
		return
	}

	n.leftNode.insert(value)
}

func printBt(node *Node) {
	if node.leftNode != nil {
		printBt(node.leftNode)
	}
	if node.rightNode != nil {
		printBt(node.rightNode)
	}
	if node.value != 0 {
		fmt.Println(node.value)
	}
}
