using System;
using System.Collections.Generic;

namespace Bellator.Models
{
    public class ProblematicItems
    {
        public List<ProblematicItem> items { get; set; }

        ProblematicItem DawnBringer = new ProblematicItem("DawnBringer", "Convert to Sunblade or 24 TCP");
        ProblematicItem DeckOfManyThings = new ProblematicItem("Deck of Many Things", "Convert to 24 TCP");
        ProblematicItem Drown = new ProblematicItem("Drown", "Convert to Story Item or 24 TCP");
        ProblematicItem GiantSizedStaffOfPower = new ProblematicItem("Giant-Sized Staff of Power (SKT)", "Convert to 24 TCP");
        ProblematicItem Hazirawn = new ProblematicItem("Hazirawn", "Convert to 24 TCP");
        ProblematicItem HolySymbolOfRavenkind = new ProblematicItem("Holy Symbol of Ravenkind", "Convert to Story Item or 24 TCP");
        ProblematicItem IconOfRavenloft = new ProblematicItem("Icon of Ravenloft", "Convert to Story Item of 24 TCP");
        ProblematicItem IronFlask = new ProblematicItem("Iron Flask", "Convert to 24 TCP");
        ProblematicItem Ironfang = new ProblematicItem("Ironfang", "Convert to Story Item or 24 TCP");
        ProblematicItem LostCrownOfBesilmer = new ProblematicItem("Lost Crown of Besilmer", "Convert to 24 TCP");
        ProblematicItem MaskOfTheDragonQueen = new ProblematicItem("Mask of the Dragon Queen", "Convert to story item or 24 TCP");
        ProblematicItem MithralSplintMail = new ProblematicItem("Mithral Splintmail +1", "Convert to Mithral Splintmail or Spintmail +1");
        ProblematicItem ShieldGuardian = new ProblematicItem("Shield Guardian (and amulet)", "Convert to 24 TCP");
        ProblematicItem SlaadControlGem = new ProblematicItem("Sladd Control Gem (any)","Convert to 24 TCP");
        ProblematicItem SpellGems = new ProblematicItem("Spell Gems (all levels)", "2 TCP per max level of spell that gem can hold (1 for cantrip)");
        ProblematicItem StaffOfTheForgottenOne = new ProblematicItem("Staff of the forgotten One", "Convert to 24 TCP");
        ProblematicItem Sunsword = new ProblematicItem("Sunsword", "Convert to Sunblade or 24 TCP");
        ProblematicItem Tinderstrike = new ProblematicItem("Tinderstrike", "Convert to Story Item or 24 TCP");
        ProblematicItem Wayth = new ProblematicItem("Waythe", "Convert to Story Item or 24 TCP");
        ProblematicItem Windvane = new ProblematicItem("Windvane", "Convert to Story Item or 24 TCP");


        public ProblematicItems()
        {
            items = new List<ProblematicItem>();
            items.Add(DawnBringer);
            items.Add(DeckOfManyThings);
            items.Add(Drown);
            items.Add(GiantSizedStaffOfPower);
            items.Add(Hazirawn);
            items.Add(HolySymbolOfRavenkind);
            items.Add(IconOfRavenloft);
            items.Add(IronFlask);
            items.Add(Ironfang);
            items.Add(LostCrownOfBesilmer);
            items.Add(MaskOfTheDragonQueen);
            items.Add(MithralSplintMail);
            items.Add(ShieldGuardian);
            items.Add(SlaadControlGem);
            items.Add(SpellGems);
            items.Add(StaffOfTheForgottenOne);
            items.Add(Sunsword);
            items.Add(Tinderstrike);
            items.Add(Wayth);
            items.Add(Windvane);

        }
    }
}
