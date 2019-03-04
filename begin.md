---
mashtemp: Mashing Temperature
batchvol: Volume in Fermenter
boiltime: Boiltime
oft: Overflow Thingy
---
# The brewing routine

## Brewblockers

* Assert.That(Glycol Chiller, Is.Connectable.To(cold water outlet));
* Assert.That(All Grain Kit, Has.All(ingredients));
* Assert.That(Fermenter, Exists);
* Assert.That(StarSan, Exists);

## First things first

The first thing to do is start heating water, so the very first thing you do is:  

1. Add the recirculation filter to the Grainfather.
2. Power up the Grainfather.
3. Add some water(5 liters will do) and press the Heat button.
4. Check your recipe and set the target temperature to the ***{{ page.mashtemp }}***  

## Calculate mash & sparge water

1. Locate the following three values:  
***{{ page.batchvol }}***  
***{{ page.boiltime }}***
2. Calculate on: https://www.grainfather.com/brewing-calculators 
3. Add the remaining mash water.
4. Assemble grainbasket with bottom perforated plate and pipeworks, including the grainstopper and place it into the Grainfather.

## brew.grainfater.com

1. Create the recipe on https://brew.grainfather.com
2. Start the Grainfather Connect App on your Android, go to recipes and update.
3. Start Session in the app and choose the recipe you just created.

## Mashing

1. ***BEEP*** Add the grain when the Grainfather reaches target temp. Not all the grain at once, but add some/stir, add some/stir until you've added it all.
2. Remove the grainstopper and add the top perforated plate. It should rest on the grainbed, do not compress the grain.
3. Add the {{ page.oft }}.  
   * **FIT** the **{{ page.oft }}** into the **HOLE** in the top perforated plate.  
     * If you have a low grainbill, about 4.5 kilograms or less, you will not be able to fit the **{{ page.oft }}** into the perforated plate. If this is the case, **RAISE** the perforated plate so that the **{{ page.oft }}** **FITS** into the **HOLE**, then add water(**you need to know how much you add in this step**) until it reaches the top perforated plate. Measure how much water you added and reduce sparge water accordingly.  
4. Add the lid and circulation pipe.
5. Start the mash on your controller or in the app.
6. Start heating sparge water.

## Sparging

1. ***BEEP*** Remove the circulation pipe and lid. Confirm on the controller or in the app. This will start heating the wort to 98&deg;C.
2. Adjust the top perforated plate so it rests on top of the grainbed again, it will have sunk some during the mash1.
3. Slowly lift the grainbasket and place it on top of the grainfather, if it's to heavy for you, get your wife to do it.
4. Clean the Jula bucket.
5. When the dripping slows down, start sparging. Don't wait until you hear no dripping at all as the manual says, this will dry out the top of the grainbed.
6. When you're done sparging, wait for the dripping to settle down, then move the grainbasket and place it on top of the Jula bucket. The Jula bucket will collect the remaining wort while, often 2-3 liters, while you move on.
7. Finish the sparging procedure on the controller or in the app. This will set the target temp to 100&deg;C so don't leave the house.

## Boiling

NB: When the temperature reaches 100&deg;C, the Grainfather will ***BEEP***. It will start boiling, but the ***boil timer will not start*** until you confirm it on the controller or in the app!

During the boil it will ***beep*** for every addition, at the configured remaining boil time. Boil addition ***BEEPS wont stop the boiltimer** but the sound is pretty annoying so confirm on the controller or in the app and then add the addition.

Near the end of the boil disinfect the chiller by running wort through it for five minutes or so. This can be rather a rather stressful task if there is a lot of additions near the end, so time it well.

Don't use the lid while disinfecting the chiller as this might cause the wort to boil over! rest the chiller on the hopspider, or be creative if you don't use a spider. Or just gamble on the lid.

When the boil timer hits zero, you can expect a ***beep***.  Raise the hopspider while letting it drain, and remove it.