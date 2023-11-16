using Chambers_of_Azus;
using Newtonsoft.Json;
using Terminal.Gui;

const UInt32 CELL_BITMASK_APERTURE = 0b0010000; // 32
const UInt32 CELL_BITMASK_ARCH = 0b00010000000000000000; // 65536
const UInt32 CELL_BITMASK_BLOCK = 0b00000000000000000000000000000001; // 1
const UInt32 CELL_BITMASK_CORRIDOR = 0b00000000000000000000000000000100; // 4
const UInt32 CELL_BITMASK_DOOR = 0b00000000000000100000000000000000; // 131072
const UInt32 CELL_BITMASK_LABEL = 0b11111111000000000000000000000000; // 4278190080
const UInt32 CELL_BITMASK_LOCKED = 0b00000000000001000000000000000000; // 262144
const UInt32 CELL_BITMASK_NOTHING = 0b00000000000000000000000000000000; // 0
const UInt32 CELL_BITMASK_PERIMETER = 0b00010000; // 16;
const UInt32 CELL_BITMASK_PORTCULLIS = 0b001000000000000000000000; // 2097152
const UInt32 CELL_BITMASK_ROOM = 0b0010; // 2
const UInt32 CELL_BITMASK_ROOM_ID = 0b1111111111000000; // 65472
const UInt32 CELL_BITMASK_SECRET = 0b000100000000000000000000; // 1048576
const UInt32 CELL_BITMASK_STAIR_DOWN = 0b010000000000000000000000; // 4194304
const UInt32 CELL_BITMASK_STAIR_UP = 0b100000000000000000000000; // 8388608
const UInt32 CELL_BITMASK_TRAPPED = 0b10000000000000000000; // 524288


string text = File.ReadAllText("Resources/The Tomb of Emirkol the Chaotic 01.json");
dynamic json_data = JsonConvert.DeserializeObject<dynamic>(text);

dynamic cells = json_data["cells"];

foreach (dynamic item in cells) {
    foreach (var cell_row in cells) {
        foreach (var cell in cell_row) {
            UInt32 cell_value = cell;

            if (cell_value != 0) {

                Console.WriteLine(cell_value);

                if ((cell_value & CELL_BITMASK_APERTURE) != 0) {
                    Console.WriteLine("CELL_BITMASK_APERTURE");
                }

                if ((cell_value & CELL_BITMASK_ARCH) != 0) {
                    Console.WriteLine("CELL_BITMASK_ARCH");
                }

                if ((cell_value & CELL_BITMASK_BLOCK) != 0) {
                    Console.WriteLine("CELL_BITMASK_BLOCK");
                }

                if ((cell_value & CELL_BITMASK_CORRIDOR) != 0) {
                    Console.WriteLine("CELL_BITMASK_CORRIDOR");
                }

                if ((cell_value & CELL_BITMASK_DOOR) != 0) {
                    Console.WriteLine("CELL_BITMASK_DOOR");
                }

                if ((cell_value & CELL_BITMASK_LABEL) != 0) {
                    Console.WriteLine("CELL_BITMASK_LABEL");
                }

                if ((cell_value & CELL_BITMASK_LOCKED) != 0) {
                    Console.WriteLine("CELL_BITMASK_LOCKED");
                }

                if ((cell_value & CELL_BITMASK_NOTHING) != 0) {
                    Console.WriteLine("CELL_BITMASK_NOTHING");
                }

                if ((cell_value & CELL_BITMASK_PERIMETER) != 0) {
                    Console.WriteLine("CELL_BITMASK_PERIMETER");
                }

                if ((cell_value & CELL_BITMASK_PORTCULLIS) != 0) {
                    Console.WriteLine("CELL_BITMASK_PORTCULLIS");
                }

                if ((cell_value & CELL_BITMASK_ROOM) != 0) {
                    Console.WriteLine("CELL_BITMASK_ROOM");
                }

                if ((cell_value & CELL_BITMASK_ROOM_ID) != 0) {
                    Console.WriteLine("CELL_BITMASK_ROOM_ID");
                }

                if ((cell_value & CELL_BITMASK_SECRET) != 0) {
                    Console.WriteLine("CELL_BITMASK_SECRET");
                }

                if ((cell_value & CELL_BITMASK_STAIR_DOWN) != 0) {
                    Console.WriteLine("CELL_BITMASK_STAIR_DOWN");
                }

                if ((cell_value & CELL_BITMASK_STAIR_UP) != 0) {
                    Console.WriteLine("CELL_BITMASK_STAIR_UP");
                }

                if ((cell_value & CELL_BITMASK_TRAPPED) != 0) {
                    Console.WriteLine("CELL_BITMASK_TRAPPED");
                }
            }
        }
    }
}


//Application.Init();

//try {
//    Application.Run(new ChambersOfAzusView());
//}
//finally {
//    Application.Shutdown();
//}