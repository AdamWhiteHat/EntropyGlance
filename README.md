# EntropyGlance - Entropy at a glance

Provides both Shannon (data) entropy and entropy as a compression ratio.
Get a more intuitive feel for the overall entropy at a glance with by visualizing both measures of entropy as a percentage of a progress bar, instead of just numbers.

![alt text](https://github.com/AdamWhiteHat/EntropyGlance/blob/master/EntropyGlance-ProgressBars.png "EntropyAtAGlance - Progress bars")

Or, view how the entropy changes across a whole file:

![alt text](https://github.com/AdamWhiteHat/EntropyGlance/blob/master/EntropyAtAGlance-Chart.png "EntropyAtAGlance - Chart")

However, standard measures of entropy are also given as well, expressing the value both as the quantity of bits/byte (on a range from 0 to 8), and as the 'normalized' value (range 0 to 1). High entropy means it the data is random-looking, like encrypted or compressed information.
The Shannon 'specific' entropy calculation makes no assumptions about the type of message it is measuring. What this means is that while a message consisting of only 2 symbols will get a very low entropy score of 0.9/8, a message of 52 symbols (the alphabet, as lower case first, then upper) repeated in the same sequence one hundred times would be yield a higher-than-average score of 6/8.
This is precisely why I included a compression ratio as a ranking of entropy that is much closer to notion of entropy that takes into account repeated patterns or predictable sequences, in the sense of Shannon's source coding theorem.


Dive deep into the symbol distribution and analysis. This screen gives you the per-symbol entropy value and the ability to sort by rank, symbol, ASCII value, count, entropy, and hex value.

![alt text](https://github.com/AdamWhiteHat/EntropyGlance/blob/master/EntropyAtAGlance-FrequencyAnalysis.png "EntropyAtAGlance - Symbol Analysis")


