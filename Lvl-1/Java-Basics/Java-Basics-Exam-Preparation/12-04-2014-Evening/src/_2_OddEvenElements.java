import java.io.InputStream;
import java.text.DecimalFormat;
import java.util.Arrays;
import java.util.Scanner;


public class _2_OddEvenElements {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		String[] firstArray = str.split(" ");
		DecimalFormat df = new DecimalFormat("##########.##");
		if (firstArray.length == 1) {
			double num = Double.parseDouble(str);
			System.out.println("OddSum="+ num + ", OddMin=" + num + ", OddMax=" + num +
						", EvenSum=No, EvenMin=No, EvenMax=No");
		}
		else if (firstArray.length == 0) {
			System.out.println("No");
		}
		else if (firstArray.length >= 2) {
			if (firstArray.length % 2 == 0) {
				double[] oddArray = new double[firstArray.length/2];
				double[] evenArray = new double[firstArray.length/2];
				for (int i = 0,j = 0; i < firstArray.length/2; i++,j+=2) {
					oddArray[i] = Double.parseDouble(firstArray[j]);
				}
				for (int i = 0,j = 1; i < firstArray.length/2; i++,j+=2) {
					evenArray[i] = Double.parseDouble(firstArray[j]);
			    }
				Arrays.sort(oddArray);
				Arrays.sort(evenArray);
				double minOdd = oddArray[0];
				double minEven = evenArray[0];
				double maxOdd = oddArray[oddArray.length - 1];
				double maxEven = evenArray[evenArray.length - 1];
				double sumOdd = 0;
				double sumEven = 0;
				for (double number : oddArray) {
					sumOdd += number;
				}
				for (double number : evenArray) {
					sumEven += number;
				}
				System.out.printf("OddSum=%1$s, OddMin=%2$s, OddMax=%3$s, EvenSum=%4$s, EvenMin=%5$s, EvenMin=%6$s"
						,df.format(sumOdd),df.format(minOdd),df.format(maxOdd),df.format(sumEven),
						df.format(minEven),df.format(maxEven));
			}
			else if (firstArray.length % 2 != 0) {
				double[] oddArray = new double[firstArray.length/2 + 1];
				double[] evenArray = new double[firstArray.length/2];
				
				for (int i = 0,j = 0; i < firstArray.length/2+1; i++,j+=2) {
					oddArray[i] = Double.parseDouble(firstArray[j]);
				}
				for (int i = 0,j = 1; i < firstArray.length/2; i++,j+=2) {
					evenArray[i] = Double.parseDouble(firstArray[j]);
			    }
				Arrays.sort(oddArray);
				Arrays.sort(evenArray);
				double minOdd = oddArray[0];
				double minEven = evenArray[0];
				double maxOdd = oddArray[oddArray.length - 1];
				double maxEven = evenArray[evenArray.length - 1];
				double sumOdd = 0;
				double sumEven = 0;
				for (double number : oddArray) {
					sumOdd += number;
				}
				for (double number : evenArray) {
					sumEven += number;
				}
				System.out.printf("OddSum=%1$s, OddMin=%2$s, OddMax=%3$s, EvenSum=%4$s, EvenMin=%5$s, EvenMin=%6$s"
						,df.format(sumOdd),df.format(minOdd),df.format(maxOdd),df.format(sumEven),
						df.format(minEven),df.format(maxEven));
			}
		}
	}
}
