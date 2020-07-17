﻿using System;
using System.Collections.Generic;

namespace DnetAutocompleteComponent.Infrastructure.Services
{
    public class AutoCompleteListService<TItem>
    {
        public event Action<List<TItem>> OnUpdateList;

        public event Action<TItem> OnItemSelected;

        public void UdateList(List<TItem> items)
        {
            OnUpdateList?.Invoke(items);
        }

        public void UpdateSelectedItem(TItem item)
        {
            OnItemSelected?.Invoke(item);
        }

    }
}
