using System;
using System.Diagnostics;

namespace chapter3_5_3 {


    public class UUIDUtils {

        public static void test() {
            Debug.Print(Guid.NewGuid().ToString()); // a2d7bbcb-0e0a-4854-b4ff-c6a61100ae57
            Debug.Print(Guid.NewGuid().ToString("N")); // 8925742a0a554f77a77f5df192ff8995
            Debug.Print(Guid.NewGuid().ToString("D")); // fe053e59-72cc-44ed-8fe5-0b0f75e86e41
            Debug.Print(Guid.NewGuid().ToString("B")); // {048d164f-c6fb-48c1-8498-1035b9de9e72}
            Debug.Print(Guid.NewGuid().ToString("P")); // (893b5f4f-8508-43ac-9920-ce76a9478bc7)
            Debug.Print(Guid.NewGuid().ToString("X")); // {0x386a1e1d,0x4003,0x4463,{0x88,0x7e,0xed,0x9c,0x8d,0x26,0xa0,0x72}}
        }

    }
}