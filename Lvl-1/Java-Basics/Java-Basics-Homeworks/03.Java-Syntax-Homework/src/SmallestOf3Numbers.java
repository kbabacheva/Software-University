
import java.util.Arrays;
import java.util.Scanner;

import com.sun.xml.internal.bind.v2.runtime.unmarshaller.XsiNilLoader.Array;


public class SmallestOf3Numbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter numbers: ");
		int[] numbers = new int[3];
		for (int i = 0; i < 3; i++) {
			numbers[i] = input.nextInt();
		}
		Arrays.sort(numbers);
		System.out.println("The smallest number is: " + numbers[0]);
	}

}
