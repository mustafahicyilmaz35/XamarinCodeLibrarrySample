﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using UILib.Annotations;
using UILib.Views.UserControls.MapViews;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace UILib.ViewModels.MapViewModels
{
    public class MapSampleViewModel
    {
        int _pinCreatedCount = 0;
        readonly ObservableCollection<Location> _locations;

        public IEnumerable Locations => _locations;

        public ICommand AddLocationCommand { get; }
        public ICommand RemoveLocationCommand { get; }
        public ICommand ClearLocationsCommand { get; }
        public ICommand UpdateLocationsCommand { get; }
        public ICommand ReplaceLocationCommand { get; }

        public MapSampleViewModel()
        {
            _locations = new ObservableCollection<Location>()
            {
                new Location("New York, USA", "The City That Never Sleeps", new Position(40.67, -73.94)),
                new Location("Los Angeles, USA", "City of Angels", new Position(34.11, -118.41)),
                new Location("San Francisco, USA", "Bay City", new Position(37.77, -122.45))
            };

            AddLocationCommand = new Command(AddLocation);
            RemoveLocationCommand = new Command(RemoveLocation);
            ClearLocationsCommand = new Command(() => _locations.Clear());
            UpdateLocationsCommand = new Command(UpdateLocations);
            ReplaceLocationCommand = new Command(ReplaceLocation);
        }

        void AddLocation()
        {
            _locations.Add(NewLocation());
        }

        void RemoveLocation()
        {
            if (_locations.Any())
            {
                _locations.Remove(_locations.First());
            }
        }

        void UpdateLocations()
        {
            if (!_locations.Any())
            {
                return;
            }

            double lastLatitude = _locations.Last().Position.Latitude;
            foreach (Location location in Locations)
            {
                location.Position = new Position(lastLatitude, location.Position.Longitude);
            }
        }

        void ReplaceLocation()
        {
            if (!_locations.Any())
            {
                return;
            }

            _locations[_locations.Count - 1] = NewLocation();
        }

        Location NewLocation()
        {
            _pinCreatedCount++;
            return new Location(
                $"Pin {_pinCreatedCount}",
                $"Desc {_pinCreatedCount}",
                RandomPosition.Next(new Position(39.8283459, -98.5794797), 8, 19));
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

