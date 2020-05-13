// CSCV 335 Final Project
// Brandon Griffing, Alex Follette, Nicolas Zarek
// Richard Alex Wong, James Sahler Parsons
// March 20th - April 8th, 2019.
//
// 4-2-1 Dice Game
// Main controller file, where most of the
// game logic is implemented


package application;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.ToggleButton;
import javafx.scene.control.ToggleGroup;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.HBox;
import javafx.scene.shape.Line;

public class CapstoneController {
	
	
	//Here are the linked buttons with GUI
	
	DiceModel player1 = new DiceModel();
	DiceModel player2 = new DiceModel();

	@FXML private TextField textFieldCurrentPlayer;
	@FXML private TextField textFieldPlayerOneScore;
	@FXML private TextField textFieldPlayerTwoScore;
	@FXML private TextField textFieldRound;
	@FXML private TextArea textAreaInstructions;
	
	//all the labels above the text fields
	@FXML private Label labelCurrentPlayer;
	@FXML private Label labelPlayerOne;
	@FXML private Label labelPlayerTwo;
	@FXML private Label labelRound;
	
	//the three roll dice buttons (1,2,3) and roll, end turn buttons
	@FXML private ToggleButton togglebtnD1;
	@FXML private ToggleButton togglebtnD2;
	@FXML private ToggleButton togglebtnD3;
	@FXML private Button rollDiceButton;
	@FXML private Button endTurnButton;
	
	//h-boxes for images
	@FXML private HBox leftDImageHBox;
	@FXML private HBox centerDImageHBox;
	@FXML private HBox rightDImageHBox;
	
	//Three toggle groups
	@FXML private ToggleGroup groupMain1;
	@FXML private ToggleGroup groupMain2;
	@FXML private ToggleGroup groupMain3;
	
	//the lines in the GUI
	@FXML private Line firstLine;
	@FXML private Line secondLine;
	@FXML private Line thirdLine;
	
	// the class wide variables
	int round = 1;             // keeps track of the round #
	int turn = 0;             // turn #
	int rollsTaken = 0;       // rolls taken
	int roundChanger = 1;     // roundChanger 1 means first roller is going
	String winner = "";
	String rollToBeat = ""; // stores current roll to beat
	
	@FXML
	private void initialize()  {
		
//		Image startDiceImage = new Image("Images/one.png");
		
		// each toggle button must get their own group or they would become radio buttons
		togglebtnD1.setToggleGroup(groupMain1);
		togglebtnD2.setToggleGroup(groupMain2);
		togglebtnD3.setToggleGroup(groupMain3);
		
		// probably not 100% necessary
		togglebtnD1.setSelected(false);
		togglebtnD2.setSelected(false);
		togglebtnD3.setSelected(false);
		
		textFieldCurrentPlayer.setText("Player1");
		textAreaInstructions.setText("Start by clicking" + "\n" + "Roll Dice button!");
		textFieldRound.setText(Integer.toString(round));
		
		// sets the starting dice pictures to one's
		changeGraphic(togglebtnD1, d1);
		changeGraphic(togglebtnD2, d1);
		changeGraphic(togglebtnD3, d1);
		
		// makes it so you can't keep any dice before you roll
		disableDice();	
	}
	
	
	//NZ added these image views
				
				//declare images
				Image d1 = new Image("images/one.png", 165, 135, true, true);
				Image d2 = new Image("images/two.png", 165, 135, true, true);
				Image d3 = new Image("images/three.png", 165, 135, true, true);
				Image d4 = new Image("images/four.png", 165, 135, true, true);
				Image d5 = new Image("images/five.png", 165, 135, true, true);
				Image d6 = new Image("images/six.png", 165, 135, true, true); 
			
	
	// This is the method that fires when you click the roll button
	public void buttonRoll() {
		roll2(player1, player2);
		}
		
	// Which in turns fires this - because we needed to pass arguments
	private void roll2(DiceModel player1, DiceModel player2) {
		
		int random;	
		
		// enables the dice to be kept
		enableDice();
		
		// reset text if player previously failed to select a die
		if (roundChanger == 2) {
			textAreaInstructions.setText(rollToBeat);
		} else {
        	textAreaInstructions.setText("Start by clicking" + "\n" + "Roll Dice button!");
        	}
		
		// display round number
		textFieldRound.setText(Integer.toString(round));
		
		// if we are on the first roller, count up rolls till they end turn
		if (roundChanger == 1) {
			rollsTaken = rollsTaken + 1;
		}
		
		// turn should increment for both rollers
		turn = turn + 1;
		
		// if all three die are selected then end turn
		if (togglebtnD1.isSelected() == true && togglebtnD2.isSelected() == true &&
				togglebtnD3.isSelected() == true) {
			endTurn();
		}
		
		// determines who has the current roll
		String currentPlayer = textFieldCurrentPlayer.getText();
		String stringPlayer1 = "Player1";
		
		// enforces player requirement of having at least 1 die selected per roll
		if (turn != 1 && togglebtnD1.isSelected() == false && togglebtnD2.isSelected() == false &&
                	togglebtnD3.isSelected() == false) {
            		if (roundChanger == 1) {
                		turn = turn - 1;
                		rollsTaken = rollsTaken - 1;
                		textAreaInstructions.setText("Please select at least 1 die to continue.");
            		} else if (roundChanger == 2 && turn == 0){
            			textAreaInstructions.setText(rollToBeat);
            		}else {
                		turn = turn - 1;
                		textAreaInstructions.setText("Please select at least 1 die to continue.");
            		}
        	} else {
			// only get new values for dice that haven't been kept		
			if (togglebtnD1.isSelected() == false) {
				random = generateRandom();
				 displayDie(random, togglebtnD1);
				if (currentPlayer.equals(stringPlayer1)) {
					player1.setDie1(random);
				} else {
					player2.setDie1(random);
				}
			} else {

			}
			if (togglebtnD2.isSelected() == false) {
				random = generateRandom();
				displayDie(random, togglebtnD2);
				if (currentPlayer.equals(stringPlayer1)) {
					player1.setDie2(random);
				} else {
					player2.setDie2(random);
				}
			} else {

			}
			if (togglebtnD3.isSelected() == false) {
				random = generateRandom();
				displayDie(random, togglebtnD3);
				if (currentPlayer.equals(stringPlayer1)) {
					player1.setDie3(random);
				} else {
					player2.setDie3(random);
				}
			} else {

			}

			// limit second rollers turns to as many turns as first roller had
			if (turn == rollsTaken && roundChanger == 2) {
				endTurn();
			}

			if (turn == 3) {                     
				endTurn();
			}
		}	
	
	}
		
	private String calculateScore(DiceModel  Player1, DiceModel  Player2) {
		
		// the variables.  first get each players dice
		int p1d1 = Player1.getDie1();
		int p1d2 = Player1.getDie2();
		int p1d3 = Player1.getDie3();
		
		int p2d1 = Player2.getDie1();
		int p2d2 = Player2.getDie2();
		int p2d3 = Player2.getDie3();
		
		int p1P = Player1.getPoints();
		int p2P = Player2.getPoints();
	
		// impParts stands for the 'important parts' used when calculating pairs (the pair)
		int impPartsP1;
		int impPartsP2;
		
		// for when the sum is needed
		int sumP1 = (p1d1 + p1d2 + p1d3);
		int sumP2 = (p2d1 + p2d2 + p2d3);
		
		// ranks are the first step in determining who won
		int rankP1 = getRank(Player1);
		int rankP2 = getRank(Player2);

		// now that ranks have been gotten, calculate winner
		// if P1 had higher rank, he wins. the end.
		if (rankP1 > rankP2) {
			winner = "Player1";
		} else if (rankP2 > rankP1) {  // if player2 has higher rank
			winner = "Player2";
		} else if (rankP1 == rankP2) { // if ranks are same
			if (rankP1 == 4) {			// if player 1 rolled 421
				if (winner.equals("Player1")) {
					winner = "Player1";
				} else {
					winner = "Player2";
				}
				winner = "Player1";
			} else if (rankP1 == 3) {  // if they are triples;
				if (sumP1 >= sumP2) {  // highest wins
					winner = "Player1";
				} else if (sumP2 > sumP1) {
					winner = "Player2";
				} else {
					if (winner.equals("Player1")) {
						winner = "Player1";
						} else {
							winner = "Player2";
						}
				}
			} else if (rankP1 == 2) {  // if they are doubles
				if (p1d1 == p1d2) {
					impPartsP1 = p1d1; // set the important part to the pair
				} else {
					impPartsP1 = p1d3;
				}
				if (p2d1 == p2d2) {  // do it for player 2 also
					impPartsP2 = p2d1;
				} else {
					impPartsP2 = p2d3;
				}
				if (impPartsP1 > impPartsP2) {  //if player1 pair is better
					winner = "Player1";
				} else if (impPartsP2 > impPartsP1) { // or p2's > p1's
					winner = "Player2";
				} else if (impPartsP1 == impPartsP2) { // if same pair
					if (sumP1 >= sumP2) {				// add them up
						winner = "Player1";
					} else if (sumP2 > sumP1) {
						winner = "Player2";
					} else {
						if (winner.equals("Player1")) {
							winner = "Player1";
							} else {
								winner = "Player2";
							}
					}
				}
				
			} else {
				if (sumP1 >= sumP2) {  // if no pairs or better, take sums
					winner = "Player1";
				} else if (sumP2 > sumP1){
					winner = "Player2";
				} else {
					if (winner.equals("Player1")) {
						winner = "Player1";
						} else {
							winner = "Player2";
						}
				}
			}
		} 	
		
		if (winner.equals("Player1")) {
			player1.setPoints(p1P + 1);
		} else {
			player2.setPoints(p2P + 1);
		}
		return winner;
	}
	
	// getRank ranks each 'hand'. a 421 is a rank 4.  triples are rank 3. pairs are rank 2.
	// slop is rank 1. then sorts them to put pairs first.
	private int getRank(DiceModel playerToRank) {
		int rank = 1;
		int ph;    // placeholder
		int d1 = playerToRank.getDie1();
		int d2 = playerToRank.getDie2();
		int d3 = playerToRank.getDie3();
		
		// sorting them in ascending order
		// switch the 2nd number into first position if it is bigger
		if (d2 > d1) {
			ph = d1;
			d1 = d2;
			d2 = ph;
		}  // switch the 3rd number into second position if it is bigger
		if (d3 > d2) {
			ph = d2;
			d2 = d3;
			d3 = ph;
		} // switch the 2nd number into first position if it is bigger
		if (d2 > d1) {
			ph = d1;
			d1 = d2;
			d2 = ph;
		}
		
		// now to get their ranking
		// check for 4,2,1
		if (d1 == 4 && d2 == 2 && d3 == 1) {
			rank = 4;
		} else if (d1 == d2 && d1 == d3) {  // checks for triples
			rank = 3;
		} else if ((d1 == d2 && d1 != d3) || d2 == d3) { // pairs
			rank = 2;
		} else {
			rank = 1;
		}
		
		return rank;
	}
	
	// BG did random generator
	// generates a random number between 1 and 6 inclusive
	public int generateRandom() {
		int random = (int)(Math.random()*((6-1)+1))+1;
		return random;
	}

	// this method fires when the end turn button is clicked
	public void buttonEndTurn() {
		endTurn();
		}
	
	// this is fired whenever a condition that needs to end a turn is met, like
	// all 3 dice are kept, or a player hits the end turn button, or if  
	// second roller has rolled the same number of times as the first roller
	// or if a player has rolled 3 times
	private void endTurn() {
		
		if (roundChanger == 1) {
			String currentPlayer = textFieldCurrentPlayer.getText();
			if (currentPlayer.equals("Player1")) {
				textAreaInstructions.setText("The current roll to beat is " + player1.getDie1()
				+ " " + player1.getDie2() + " " + player1.getDie3());
				rollToBeat = "The current roll to beat is " + player1.getDie1()
				+ " " + player1.getDie2() + " " + player1.getDie3();
			} else {
				textAreaInstructions.setText("The current roll to beat is " + player2.getDie1()
				+ " " + player2.getDie2() + " " + player2.getDie3());
				rollToBeat = "The current roll to beat is " + player2.getDie1()
				+ " " + player2.getDie2() + " " + player2.getDie3();
			} 
			changeCurrentPlayerText();
			turn = 0;
			roundChanger = 2;
		} else {
			String winningPlayer = calculateScore(player1, player2);
			textFieldCurrentPlayer.setText(winningPlayer);
			roundChanger = 1;
			rollsTaken = 0;
			round = round + 1;
			textFieldPlayerOneScore.setText(Integer.toString(player1.getPoints()));
			textFieldPlayerTwoScore.setText(Integer.toString(player2.getPoints()));
			textAreaInstructions.setText("Try to get the highest roll possible!");
			checkForGameOver();
		}
		togglebtnD1.setSelected(false);
		togglebtnD2.setSelected(false);
		togglebtnD3.setSelected(false);
		disableDice();
		turn = 0;
	}
	
	// changes the current player
	private void changeCurrentPlayerText() {
		String currentPlayer = textFieldCurrentPlayer.getText();
		if (currentPlayer.equals("Player1")) {
			textFieldCurrentPlayer.setText("Player2");
		} else {
			textFieldCurrentPlayer.setText("Player1");
		} 
	}
	
	// checks to see if game is over
	private void checkForGameOver() {
		// if 11 rounds are over, calculate winner
		if (round == 12) {
			if (player1.getPoints() > player2.getPoints()) {
				textAreaInstructions.setText("Game Over!! Player 1 wins!!");
			} else {
				textAreaInstructions.setText("Game Over!! Player 2 Wins!!");
			}
			round = 1;
			textFieldRound.setText("1");
			textFieldPlayerOneScore.setText("0");
			textFieldPlayerTwoScore.setText("0");
			player1.setPoints(0);
			player2.setPoints(0);
		}
	}
	
	// checks the value of the random number to know which dice picture to draw
	private void displayDie(int randomNumber, ToggleButton toggleButtonToChange) {
		
		switch (randomNumber) {
		case 1: changeGraphic(toggleButtonToChange, d1);
		break;
		case 2: changeGraphic(toggleButtonToChange, d2);
		break;
		case 3: changeGraphic(toggleButtonToChange, d3);
		break;
		case 4: changeGraphic(toggleButtonToChange, d4);
		break;
		case 5: changeGraphic(toggleButtonToChange, d5);
		break;
		case 6: changeGraphic(toggleButtonToChange, d6);
		break;
		}
		
	}
	
	// changes the dice pictures to what is needed from method above
	private void changeGraphic(ToggleButton toggleButton, Image diceImage){
	     toggleButton.setGraphic(new ImageView(diceImage));
	}
	
	private void disableDice() {
		// makes it so you can't select dice if you haven't rolled
		togglebtnD1.setDisable(true);
		togglebtnD2.setDisable(true);
		togglebtnD3.setDisable(true);
		endTurnButton.setDisable(true);
	}
	
	private void enableDice() {
		// makes it so you can keep the dice after you roll once
		togglebtnD1.setDisable(false);
		togglebtnD2.setDisable(false);
		togglebtnD3.setDisable(false);
		endTurnButton.setDisable(false);
	}
	
}

