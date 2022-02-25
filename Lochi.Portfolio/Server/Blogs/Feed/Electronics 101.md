# How I got started with electronics 😲!
## The start 😎
Hello internet! This is my first blog so go easy on me! 😁 So, today we will be looking at how I got started 
with basic electronics and also record here some things that I wish I knew beforehand! This will cover what I did last week, the very first week
that I messed around with electronics. We will be going through all the
circuits that I made with the first few basic components that I bought! Disclaimer: I am by no means a professional and most of the things 
I've made are from the youtube vids below and the copy of NEETS that I found on reddit! if you find anything that is wrong
in this blog, please feel free to let me know below (might take a while to get my comment section going)

> <a href="https://www.youtube.com/playlist?list=PLah6faXAgguOeMUIxS22ZU4w5nDvCl5gs" target="_blank">CodeNMore's beginners electronics series</a>

> <a href="https://www.youtube.com/watch?v=sTu3LwpF6XI" target="_blank">Ben Eater's making logic gates from transistors video</a>

> <a href="https://www.reddit.com/r/electronics/comments/6gd5x8/the_complete_navy_electricity_and_electronics/?utm_source=share&utm_medium=web2x&context=3" target="_blank">NEETS</a>
## What I ordered 💵
- A basic cheap breadboard
- Resistors (180, 220, 330, 470, 6xx, 1k, 2k) (values in ohms)
- LEDs 
- Batteries (9V, 1.5V)
- Transistors (a few models of NPN and PNP)
- Buttons and switches
- Capacitors 
	> Tho I wish I ordered some with higher µF values! The max I had was like 47 µF
### I ordered a bunch more stuff but only ended up using ***most*** of the above in my first week of electronics work 😁

### Stats

- LEDs burned: 3 📉
- Disastorous wiring, Jumpers are great but I wish hadn't choosen em for everything but hey it is what it is, def not next time
- Never used the multimeter i bought 😲

## Circuits I made ⚡

### Basics

<video controls width="750" height="500">
    <source src="/api/blog/videoplayback?fileName=basic_electronics_no_audio.mp4"
            type="video/mp4">
</video>

So starting off, in the video above I made the following schematic

![basic circuit](/images/electronics_101/basic_circuit.png)

It is your basic stuff tbh, your basic use of a resistor and a switch to light up LEDs. 
The only thing special here is like in one of CodeNMores videos I used a DPDT switch as SPST one.
His video on switches was very helpful 😁

### The buffer

Alright now it's time for some logic gates! Pretty exciting to make your own &s, |s and ^s 💥🤯

<video controls width="750" height="500">
    <source src="/api/blog/videoplayback?fileName=buffer-no-audio.mp4"
            type="video/mp4">
</video>

The first one as you can see above is called the buffer. Ig that makes sense cuz it technically holds a "bit", and 
I also noticed when I touch the resistor my body acts like a postive terminal, so current flow through us huh! 🤷‍
Am not gonna draw the circuit cuz it's pretty similar to the inverter below and you should be able to figure it out 😃

### I should probably explain how the transistor works on a high level tho, basically when a + voltage is supplied to the middle 
terminal (aka the base) current can flow through the left terminal (called the emmiter) to the right (called the collector). This allows
it to act like a switch. The voltage on the base should be positive but should be a lot less than the one on the collector 
so we use a resistor with a high value. 
Now you'll notice the naming sounds odd, if anything, the emmiter should output current right?
Well I think it has to do with "Conventional Current" (which is basically assuming + -> - electron flow). But idrk
I'm too used to the - -> + flow and it's just a headache to switch so bear with me for a few more weeks 🤣

### The inverter

<video controls width="750" height="500">
    <source src="/api/blog/videoplayback?fileName=inverter_no_audio.mp4"
            type="video/mp4">
</video>

So this one is pretty basic too but this is interesting circuitry!

![inverter](/images/electronics_101/inverter.png)

### Sorry about the pop up but that's just the resistor behind it. Such pia to use circuit lab without signing up, like cmon man

![cmon really circuitlab?](https://c.tenor.com/DrOJklqI34kAAAAC/key-and-peele-come-on.gif)

So this works because current can flow as normal when the switch is on (where the transistor is off). As soon as you push the button
current can flow through the transistor and voltage difference accross the LED is cut off! pretty neat! 😲

### The AND gate

<video controls width="750" height="500">
    <source src="/api/blog/videoplayback?fileName=AND_no_audio.mp4"
            type="video/mp4">
</video>

Now we are getting into two transistor teritory!

![AND](/images/electronics_101/AND.png)

Now idk if there's anything here to explain at all so all I'm gonna say is unlike in the OR gate you need to
connect the transistors in series. You can see this below from the OR circuit below. I did make the OR gate but forgot to record
😂🤦‍


![OR](/images/electronics_101/OR.png)

### ^ The OR Circuit

### The XOR gate 🤯 (true ^ true => false)

<video controls width="750" height="500">
    <source src="/api/blog/videoplayback?fileName=XOR-no-audio.mp4"
            type="video/mp4">
</video>

I guess exclusivity comes at a price cuz this has been the hardest one and the last one I'm gonna make on a 
breadboard. Sorry about the wiring 😁. I recommend you don't think about this too much and worry about this when you
actually get started with electronics. So I am not going to explain it here cuz even drawing this thing was a pain.
CircuitLab failed me so I spent hours trying out different applications, that certainly did not help. Anyway,
the circuits are below for your reference, tbh, I don't even know it's correct! The first one is
incomplete because they didn't let me continue to use circuit lab without signing up but the wiring is more clearer
(f u circuitlab!)😒

### Quick note: notice I'm using 1k ohm resistor for the LED? Yeah even tho this worked at first the LED was only dimmed.
### So yeah, high resistance was the only solution I could find to fix that. That is why I'm pointing out in the vid 😁

![XORIncomplete](/images/electronics_101/XOR_incomplete.png)

![XOR](/images/electronics_101/XOR.png)

## And that is a wrap!

Thank you for reading and listening to my rants about circuitlab. And I will see you 👇, in week 2! 
(Hopefully with a better simulator) 🤣