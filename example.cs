

            retest:;

            // ntread
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 500000; i++)
            {
                Read<ulong>(client_dll + offsets.dwlocalplayer);
            }
            stopwatch.Stop();
            double elapsedTime = stopwatch.Elapsed.TotalMilliseconds;
            Console.WriteLine("[ntdll.dll] NtReadVirtualMemory bellek okuma süresi -> " + elapsedTime + "ms");


            // read
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            for (int i = 0; i < 500000; i++)
            {
                Read2<ulong>(client_dll + offsets.dwlocalplayer);
            }

            stopwatch2.Stop();
            double elapsedTime2 = stopwatch2.Elapsed.TotalMilliseconds;
            Console.WriteLine("[kernel32.dll] ReadProcessMemory bellek okuma süresi -> " + elapsedTime2 + "ms");


            Console.ReadKey();
            goto retest;
