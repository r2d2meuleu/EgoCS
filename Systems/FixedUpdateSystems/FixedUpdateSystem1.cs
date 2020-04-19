﻿namespace EgoCS
{
    public abstract class FixedUpdateSystem< EI, TEgoConstraint1 > : FixedUpdateSystem< EI >
        where EI : EgoCS, new()
        where TEgoConstraint1 : Constraint, new()
    {
        private readonly TEgoConstraint1 constraint1 = new TEgoConstraint1();

        public abstract void FixedUpdate( EI egoInterface, TEgoConstraint1 egoConstraint1 );

        public override void FixedUpdate( EI egoInterface )
        {
            FixedUpdate( egoInterface, constraint1 );
        }

        public override void CreateConstraintCallbacks( EI egoInterface )
        {
            constraint1.CreateConstraintCallbacks( egoInterface );
        }

        public override void CreateBundles( EgoComponent egoComponent )
        {
            constraint1.CreateBundles( egoComponent );
        }
    }
}