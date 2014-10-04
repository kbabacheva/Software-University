import java.util.Scanner;
import java.util.TreeMap;


public class _11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputStr = input.nextLine().toLowerCase();
		String[] words = inputStr.split("\\W+");
		int counter = 0;
        TreeMap<String, Integer> wordsMap = new TreeMap<>();
        
        for (int i = 0; i < words.length; i++) {
                if(!wordsMap.containsKey(words[i])){
                        wordsMap.put(words[i], 1);
                }
                else {
                        wordsMap.put(words[i], wordsMap.get(words[i]) + 1);
                        if(wordsMap.get(words[i]) > counter) {
                                counter = wordsMap.get(words[i]);
                        }
                }
        }
       
        for (String key : wordsMap.keySet()) {
                if(wordsMap.get(key) == counter) {
                        System.out.print(key + " -> " + wordsMap.get(key) + " times");
                        System.out.println();
                }
        }
	}

}
