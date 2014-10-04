import java.util.ArrayList;
import java.util.Scanner;

public class _4_LongestAlphabeticalWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String word = input.nextLine().toLowerCase();
		int size = input.nextInt();
		String longestSequence = "";
		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				ArrayList<Character> top = getSequence(word, size, i, j, -1, 0);
				ArrayList<Character> right = getSequence(word, size, i, j, 0, 1);
				ArrayList<Character> bottom = getSequence(word, size, i, j, 1, 0);
				ArrayList<Character> left = getSequence(word, size, i, j, 0, -1);
			}
		}

	}

	private static char getLetterAt(String word, int size, int row, int col) {
		return word.toCharArray()[(size * row + col) % word.length()]; // % - a way to make it loop
	}

	private static ArrayList<Character> getSequence(String word, int size,
			int row, int col, int nextRow, int nextCol) {
		ArrayList<Character> currentSequence = new ArrayList<>();
		Character currentLetter = getLetterAt(word, size, row, col);

		currentSequence.add(currentLetter);
		while (true) {
			if (!(row + nextRow > 0 && row + nextRow < size
					&& col + nextCol > 0 && col + nextCol < size)) {
				break;
			}

			Character nextLetter = getLetterAt(word, size, row + nextRow, col
					+ nextCol);
			row += nextRow;
			col += nextCol;

			// The sequence goes out of alphabetical order
			if (nextLetter < currentLetter) {
				break;
			}
			currentLetter = getLetterAt(word, size, row, col);
			currentSequence.add(currentLetter);
		}
		return currentSequence;
	}

	private static String getBestWord(String firstWord, String secondWord) {
		if (firstWord.length() > secondWord.length()) {
			return firstWord;
		} else if (firstWord.length() < secondWord.length()) {
			return secondWord;
		}
		else {
			if (firstWord.compareTo(secondWord) > 0 ) {
				return firstWord;
			}
			else {
				return secondWord;
			}
		}
	}
}
