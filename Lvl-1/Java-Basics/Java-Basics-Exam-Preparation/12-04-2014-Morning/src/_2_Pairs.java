import java.util.Arrays;
import java.util.Scanner;


public class _2_Pairs {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine();
		String[] firstArray = inputStr.split(" ");
		int[] intArray = new int[firstArray.length];
		
		for (int i = 0; i < intArray.length; i++) {
			intArray[i] = Integer.parseInt(firstArray[i]);
		}
		int[] pairs = new int[intArray.length/2];
		for (int i = 0,j=0; i < pairs.length; i++,j+=2) {
			pairs[i] = intArray[j] + intArray[j+1];
			//System.out.println(pairs[i]);
		}
		Arrays.sort(pairs);
		if (pairs.length > 2) {
			for (int i = 0; i < pairs.length-1; i++) {
				if (pairs[i] == pairs[i+1]) {
					System.out.println("Yes, value=" + pairs[i]);
					break;
				}
				else {
					System.out.println("No, maxdiff=" + (pairs[pairs.length-1] - pairs[0]));
					break;
				}
			}
		}
		else if (pairs.length <= 2) {
			if (intArray[0] == intArray[1]) {
				System.out.println("Yes, value="+intArray[0]*2);
			}
			else {
				if (intArray[0] > intArray[1]) {
					System.out.println("No, maxdiff=" + (intArray[0] - intArray[1]));
				}
				else if (intArray[0] < intArray[1]) {
					System.out.println("No, maxdiff=" + (intArray[1] - intArray[0]));
				}
			}
		}
	}

}
