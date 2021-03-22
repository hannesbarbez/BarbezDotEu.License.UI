# License Key Generator

Produces license keys you don't mind spelling out loud to another person.

A demo generator for human-friendly, readable license keys and serial numbers using https://www.nuget.org/packages/BarbezDotEu.License.Generation and https://www.nuget.org/packages/BarbezDotEu.License.Verification.

![Generating 30 000 unique keys in a matter of seconds.](https://barbez.eu/wp-content/uploads/2020/10/image-1.png)

Generating 30 000 unique keys in a matter of seconds.

The Barbez.eu license key generator is ideal for all your license key or serial number generation needs, producing keys or serials that are easy to read out loud one human to another. Yet, the algorithm is quick enough to generate a decent amount of them in a short period of time.

This UI demo project uses the generic https://github.com/hannesbarbez/BarbezDotEu.License for actual generation of keys/serials.

## Table of Contents
1. [Features](#features)
2. [Custom Resulting-Sum Algorithm](#custom-resulting-sum-algorithm)
3. [Performance](#performance)
4. [Stats](#stats)
5. [Graphs](#graphs)
6. [Eye-Candy](#eye-candy)

## Features
- Full multithreading, thanks to .NET Core’s TPL (Task Parallel Library);
- Custom “resulting-sum” algorithm to generate a bunch of unique license keys quickly;
- Responsive UI, built in WinForms (glamorous, indeed);
- On-the-fly license key validator;
- Decoupling, e.g. strict separation between UI and logic;
- Generated license keys that are easy for people to spell out loud.

## Custom Resulting-Sum Algorithm

The generator algorithm was made up in a matter of hours, the whole app (including a recent rewrite) took a couple of days to write.

Lacking academic knowledge on serial number or license key generation algos, and since this algorithm is my own, I’ve decided to dub it “resulting-sum” generation.

See the source code for the exact working of the algorithm.

## Performance
After running a couple of tests on an AMD Ryzen 1600 (6 cores, 12 threads) based machine, I compiled a short table with the results.

On this hardware, a ResultingSum of 68 takes Y time to render/generate X number of unique keys. The sweet-spots are marked in bold in the below table.

Results will differ for other ResultingSum values. For a value of 68, 30 000 unique keys are generated in under 9 seconds.

The going gets tougher when generating 150 000 unique keys in exactly 4 minutes. Lawd.

## Stats
*Note: these stats are from the initial version of the NuGet package. Newer versions of the package are quicker, yet the overal trend of the graphs remains.*

A "resulting sum" of 68 takes Y time to render/generate X number of unique keys on a Ryzen 1600 based machine.

| Keys (X) | Time (ms, Y) | ms/key (=Y/X) |
| -------- | ------------ | ------------- |
| 1 | **12** | **12.00** |
| 10 | **13** | **1.30** |
| 100 | **32** | **0.32** |
| 1 000 | **146** | **0.15** |
| 2 500 | **358** | **0.14** |
| 5 000 | **719** | **0.14** |
| 10 000 | **1 500** | **0.15** |
| 20 000 | **4 800** | **0.24** |
| **30 000** | **8 600** | **0.29** |
| 50 000 | 21 300 | 0.43 |
| 62 500 | 31 500 | 0.50 |
| 75 000 | 43 800 | 0.58 |
| 87 500 | 66 000 | 0.75 |
| 100 000 | 84 000 | 0.84 |
| 150 000 | 240 000 | 1.60 |

## Graphs
*Note: these stats are from the initial version of the NuGet package. Newer versions of the package are quicker, yet the overal trend of the graphs remains.*

![Y time needed (ms) to generate X number of keys.](https://barbez.eu/wp-content/uploads/2020/09/image-4.png)
![Y time needed (ms) per key when generating X number of keys.](https://barbez.eu/wp-content/uploads/2020/09/image-3.png)

## Eye-Candy
Maybe not so much. After all, it’s WinForms in 2020.

![After startup.](https://barbez.eu/wp-content/uploads/2020/09/image-2.png)

After startup.

![Thinking hard.](https://barbez.eu/wp-content/uploads/2020/09/image.png)

Thinking hard.

![On-the-fly testing of one of the generated license keys.](https://barbez.eu/wp-content/uploads/2020/09/image-5.png)

On-the-fly testing of one of the generated license keys.

![Better luck next time.](https://barbez.eu/wp-content/uploads/2020/09/image-6.png)

Better luck next time.

## Author
www.barbez.eu
