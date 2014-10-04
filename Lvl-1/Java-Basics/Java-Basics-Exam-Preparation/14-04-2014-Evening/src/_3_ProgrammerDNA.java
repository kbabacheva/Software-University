import java.util.Scanner;


public class _3_ProgrammerDNA {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = Integer.parseInt(input.nextLine());
		char ch = input.next().charAt(0);
		char dot = '.';
		int blockSize = 7;
		int midPoint = blockSize / 2;
		int diff = 0;
		int diffCounter = 0;
		for (int i = 0; i < n; i++) {
			//Print block
			for (int j = 0; j < blockSize; j++) {
				if (j >= midPoint - diff && j <= midPoint + diff) {
					System.out.print(ch);
					//Changing letters
					if (ch == 'G') {
						ch = 'A';
					}
					else {
						ch++;
					}
				}
				else {
					System.out.print(dot);
				}
			}
			if (diffCounter >= midPoint) {
				diff--;
			}
			else {
				diff++;
			}
			diffCounter++;
			if (diffCounter == blockSize) {
				diffCounter = 0;
				diff++;
			}
			System.out.println();
		}
	}

}
