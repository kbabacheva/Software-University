import java.util.Scanner;


public class PointsInsideAFigure {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine();
		String[] strArray = inputStr.split(" ");
		double x = Double.parseDouble(strArray[0]);
		double y = Double.parseDouble(strArray[1]);
        if(y < 6 || y > 13.5) System.out.println("Outside");
        else
        {
                if(x < 12.5 || x > 22.5) System.out.println("Outside");
                else
                {
                        if(x  >17.5 && x < 20 && y > 8.5) System.out.println("Outside");
                        else System.out.println("Inside");
                }
        }
	}

}
