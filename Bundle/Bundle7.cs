﻿namespace EgoCS
{
    using UnityEngine;

    public class Bundle< TComponent1, TComponent2, TComponent3, TComponent4, TComponent5, TComponent6, TComponent7 > : Bundle
        where TComponent1 : Component
        where TComponent2 : Component
        where TComponent3 : Component
        where TComponent4 : Component
        where TComponent5 : Component
        where TComponent6 : Component
        where TComponent7 : Component
    {
        public readonly TComponent1 component1;
        public readonly TComponent2 component2;
        public readonly TComponent3 component3;
        public readonly TComponent4 component4;
        public readonly TComponent5 component5;
        public readonly TComponent6 component6;
        public readonly TComponent7 component7;

        public Bundle( TComponent1 component1, TComponent2 component2, TComponent3 component3, TComponent4 component4, TComponent5 component5, TComponent6 component6, TComponent7 component7 )
        {
            this.component1 = component1;
            this.component2 = component2;
            this.component3 = component3;
            this.component4 = component4;
            this.component5 = component5;
            this.component6 = component6;
            this.component7 = component7;
        }
    }
}