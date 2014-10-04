import java.util.ArrayList;
import java.util.Scanner;


public class _9_CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String firstInput = input.nextLine();
		String secondInput = input.nextLine();
		String[] first = firstInput.split(" ");
		String[] second = secondInput.split(" ");
		
		ArrayList<Character> l1 = new ArrayList<> ();
		ArrayList<Character> l2 = new ArrayList<> ();
		ArrayList<Character> l3 = new ArrayList<> ();
		
		for (int i = 0; i < first.length; i++) {
			l1.add(i,first[i].charAt(0));
		}
		l3.addAll(l1);
		for (int i = 0; i < second.length; i++) {
			l2.add(i,second[i].charAt(0));
		}
		for (int i = 0; i < l2.size(); i++) {
			if (!(l3.contains(l2.get(i)))) {
				l1.add(l2.get(i));
			}
		}
		for (Character character : l1) {
			System.out.print(character + " ");
		}
	}

}
