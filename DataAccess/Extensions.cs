using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace DataAccess
{
    /// <summary>
    /// Data access related extension methods
    /// </summary>
    public static class Extensions
    {

        /// <summary>
        /// Sets the modified state property for all properties of the entity
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="entity">The entity you want to modify</param>
        /// <param name="context">The context of the entity</param>
        public static void SetAllModified<T>(this T entity, ObjectContext context)
            where T : IEntityWithKey
        {
            var stateEntry = context.ObjectStateManager.GetObjectStateEntry(entity.EntityKey);
            var propertyNameList = stateEntry.CurrentValues.DataRecordInfo.FieldMetadata.Select
              (pn => pn.FieldType.Name);
            foreach (var propName in propertyNameList)
                stateEntry.SetModifiedProperty(propName);
        }


    }
}
