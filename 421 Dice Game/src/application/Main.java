// CSCV 335 Final Project
// Brandon Griffing, Alex Follette, Nicolas Zarek
// Richard Alex Wong, James Sahler Parsons
// March 20th - April 8th, 2019.
//
// 4-2-1 Dice Game
// Main file, sets the stage and 
// implements the FXML file

package application;
	
import javafx.application.Application;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.layout.GridPane;
import javafx.fxml.FXMLLoader;


public class Main extends Application {
	@Override
	public void start(Stage primaryStage) {
		try {
			GridPane root = (GridPane)FXMLLoader.load(getClass().getResource("IntroScreenUI.fxml"));
			Scene scene = new Scene(root, 590, 428);
			scene.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
			primaryStage.setScene(scene);
			primaryStage.show();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		launch(args);
	}
}
