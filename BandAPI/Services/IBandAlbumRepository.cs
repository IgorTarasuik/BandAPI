﻿using BandAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Services
{
    public interface IBandAlbumRepository
    {
        IEnumerable<Album> GetAlbums(Guid Bandid);
        Album GetAlbum(Guid BandId, Guid albumId);
        void AddAlbum(Guid bandId, Album album);
        void UpdateAlbum(Album album);
        void DeleteAlbum(Album album);

        IEnumerable<Band> GetBands();
        Band GetBand(Guid Bandid);
        IEnumerable<Band> GetBands(IEnumerable<Guid> bandIds);
        void AddBand(Band band);
        void UpdateBand(Band band);
        void DeleteBand(Band band);

        bool BandExists(Guid bandId);
        bool AlbumExists(Guid albumId);
        bool Save();

    }
}
