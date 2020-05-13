package application;
import java.io.IOException;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.stage.Stage;

public class IntroScreenController {
	@FXML
	private Button playButton;
	
	@FXML
	private void intialize() {
		
	}

	public void playButtonClicked (ActionEvent event) throws IOException {
		Parent parentScene = FXMLLoader.load(getClass().getResource("CapstoneUI.fxml"));
		Scene newScene = new Scene(parentScene);

		Stage CurrentWindow = (Stage) ((Node) event.getSource()).getScene().getWindow();
		CurrentWindow.setScene(newScene);
		CurrentWindow.show();


	}
}
