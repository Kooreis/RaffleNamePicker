import random

def raffle_name_picker():
    participants = []
    while True:
        print("1. Add participant")
        print("2. Pick a winner")
        print("3. Exit")
        choice = input("Enter your choice: ")
        if choice == '1':
            name = input("Enter participant's name: ")
            participants.append(name)
        elif choice == '2':
            if len(participants) == 0:
                print("No participants added yet.")
            else:
                winner = random.choice(participants)
                print("The winner is: " + winner)
        elif choice == '3':
            break
        else:
            print("Invalid choice. Please choose again.")

if __name__ == "__main__":
    raffle_name_picker()