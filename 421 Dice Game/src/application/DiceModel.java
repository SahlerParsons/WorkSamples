package application;

//CSCV 335 Final Project
//Brandon Griffing, Alex Follette, Nicolas Zarek
//Richard Alex Wong, James Sahler Parsons
//March 20th - April 8th, 2019.
//
//4-2-1 Dice Game
//DiceModel file, the model
//for the Player's dice values and points

public class DiceModel {
	
	private String owner;
	private int die1;
	private int die2;
	private int die3;
	private int points;

	public String getOwner() {
		return owner;
	}
	public void setOwner(String owner) {
		this.owner = owner;
	}
	public int getDie1() {
		return die1;
	}
	public void setDie1(int die1) {
		this.die1 = die1;
	}
	public int getDie2() {
		return die2;
	}
	public void setDie2(int die2) {
		this.die2 = die2;
	}
	public int getDie3() {
		return die3;
	}
	public void setDie3(int die3) {
		this.die3 = die3;
	}
	public int getPoints() {
		return points;
	}
	public void setPoints(int points) {
		this.points = points;
	}


}
