```java
import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class RaffleNamePicker {
    public static void main(String[] args) {
        ArrayList<String> names = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        String input = "";

        while (!input.equals("end")) {
            System.out.println("Enter a name or type 'end' to finish:");
            input = scanner.nextLine();
            if (!input.equals("end")) {
                names.add(input);
            }
        }

        Random random = new Random();
        String winner = names.get(random.nextInt(names.size()));
        System.out.println("The winner is: " + winner);
    }
}
```